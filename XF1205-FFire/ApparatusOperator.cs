using DevExpress.UnitConversion;
using DevExpress.XtraRichEdit.Model;
using FluentModbus;
using System.IO.Ports;

namespace XF1205_FFire
{
    public enum OperationType
    {
        Read,
        Write
    }
    public class ApparatusOperator
    {
        private ModbusRtuClient _client = null!; // 温度模块通信对象

        private ModbusRtuClient _relay = null!;  // 串口通信对象

        private int _deviceAddress;

        private int _relayAddress;

        private ushort _oilTemp;   // 当前油温热电偶的温度(单位:0.1℃)

        private int _valveStatus;  // 燃气电磁阀当前状态(0:关闭状态 | 1:开启状态)

        public ushort OilTemperature 
        {
            get { return _oilTemp; }
            set { _oilTemp = value; }
        }

        public int ValveStatus
        {
            get { return _valveStatus; }
            set { _valveStatus = value; }
        }

        public ApparatusOperator()
        {
            // 设置设备通信地址
            _deviceAddress = 0x01;
            _relayAddress = 0x01;
            // 初始化设备连接参数
            _client = new();
            _client.BaudRate = 9600;
            _client.Parity = Parity.None;
            _client.StopBits = StopBits.One;
            _client.ReadTimeout = 5000;
            _client.WriteTimeout = 5000;

            _relay = new();
            _relay.BaudRate = 9600;
            _relay.Parity = Parity.None;
            _relay.StopBits = StopBits.One;
            _relay.ReadTimeout = 5000;
            _relay.WriteTimeout = 5000;

            // 初始化传感器默认值
            _oilTemp = 8888;
            _valveStatus = 0;
        }

        /*
         * 功能: 初始化试验设备
         */
        public void InitializeApparatus()
        {
            // 初始化设备状态值
            _oilTemp = GetOilTemperature();
            _valveStatus = GetValveStatus();            

            // 启动传感器数据采集线程
            var daq = new DAQLocal();
            daq.StartDAQ();
        }

        /*
         * 功能: 建立与试验设备的实际连接         
         * 返回:
         *       true  - 成功连接所有接口
         *       false - 至少有一个接口连接失败
         */
        public bool EstablishConnection(string port,string port2)
        {
            try
            {
                _client.Connect(port, ModbusEndianness.BigEndian);
                if (!_client.IsConnected)
                {
                    // 温度模块连接失败
                    return false;
                }

                _relay.Connect(port2, ModbusEndianness.BigEndian);
                if (!_relay.IsConnected)
                {
                    // 电磁阀控制模块连接失败
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"系统提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
           
            return true;
        }

        /*
         * 功能: 电磁阀控制函数
         * 参数:
         *       status - 开闭状态(true:开启|false:关闭)
         * 返回:
         *       true - 设置成功
         *       data - 若执行成功,为最新状态值
         *       err -  若执行失败,为错误代码(仅返回错误时有效)
         */
        public (bool, int) SetValveStatus(int status)
        {
            var (ret,data) = SendValveModuleCmd(OperationType.Write, status == 0 ? (ushort)0x0003 : (ushort)0x0002, 1);
            if (ret)
            {
                _valveStatus = status;
            }
            return (ret, _valveStatus);
        }

        /*
         * 功能: 读取电磁阀状态
         * 参数:
         *       无
         * 返回:
         *       true - 指令执行成功
         *       data - 若执行成功,为最新状态值
         *       err -  若执行失败,为错误代码(仅返回错误时有效)
         */
        public int GetValveStatus()
        {
            return _valveStatus;
        }

        /*
         * 功能: 获取热电偶当前温度值
         */
        public ushort GetOilTemperature()
        {
            var (ret, data) = SendTemperatureModuleCmd(OperationType.Read, 0x0102, 0);
            if (ret)
            {
                _oilTemp = data;
            }
            return _oilTemp;
        }

        /* =========定义设备的执行动作函数,这些函数使用设备的通信端口发送控制指令 ========== */

        /*
         * 功能: 同步所有写指令
         * 参数:
         *       type    - 操作类型
         *       address - 寄存器地址
         *       value   - 要写入指定地址的值
         * 返回:
         *       (bool,ushort) - 操作成功则返回true以及获取的结果值(仅限读操作)
         */
        private (bool, ushort) SendTemperatureModuleCmd(OperationType type, ushort register, ushort value)
        {
            bool ret = false;
            ushort data = 0;
            lock (this)
            {
                try
                {
                    if (_client.IsConnected)
                    {
                        if (type == OperationType.Write)
                        {
                            _client.WriteSingleRegister(_deviceAddress, register, value);
                            ret = true;
                        }
                        else if (type == OperationType.Read)
                        {
                            data = _client.ReadHoldingRegisters<ushort>(_deviceAddress, register, 1)[0];
                            ret = true;
                        }
                    }
                }
                catch (TimeoutException e)
                {
                    MessageBox.Show(e.Message,"系统异常",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    ret = false;
                    data = 0;
                }
                catch (ModbusException e)
                {
                    MessageBox.Show(e.Message, "系统异常", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ret = false;
                    data = 0;
                }
                return (ret, data);
            }
        }

        /*
         * 功能: 同步电磁阀控制指令
         * 参数:
         *       type    - 操作类型
         *       address - 寄存器地址
         *       value   - 要写入指定地址的值
         * 返回:
         *       (bool,ushort) - 操作成功则返回true以及获取的结果值(仅限读操作)
         */
        private (bool, ushort) SendValveModuleCmd(OperationType type, ushort register, ushort value)
        {
            bool ret = false;
            ushort data = 0;
            lock (this)
            {
                try
                {
                    if (_relay.IsConnected)
                    {
                        if (type == OperationType.Write)
                        {
                            _relay.WriteSingleRegister(_relayAddress, register, value);
                            ret = true;
                        }
                        else if (type == OperationType.Read)
                        {
                            data = _relay.ReadHoldingRegisters<ushort>(_relayAddress, register, 1)[0];
                            ret = true;
                        }
                    }
                }
                catch (TimeoutException e)
                {
                    ret = false;
                    data = 0;
                    MessageBox.Show(e.Message, "系统异常", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (ModbusException e)
                {
                    ret = false;
                    data = 0;
                    MessageBox.Show(e.Message, "系统异常", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                return (ret, data);
            }
        }
    }
}