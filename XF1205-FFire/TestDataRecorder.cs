using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XF1205_FFire
{
    /* 直接从传感器采集数据的版本(从SignalR客户端获取传感器数据的版本另做开发) */
    public class TestDataRecorder
    {
        //计时线程
        private readonly System.Threading.Timer _timer;
        // 数据采集计数器
        private int _counter;
        // 传感器最新数据
        private SensorData _sensorData;
        // 传感器原始数据缓存
        private List<SensorData> _sensorDataBuffer;
        // 样品试验视图窗体对象
        private TestForm? _view;
        // 视图显示模型
        private TestViewModel _viewModel;
        public TestDataRecorder()
        {
            _timer = new(RecordData);
            _counter = 0;
            _sensorData = new SensorData();
            _sensorDataBuffer = new List<SensorData>();
            _viewModel = new();
        }

        public void BindView(TestForm view)
        {
            _view = view;
        }

        /* 从全局传感器数据缓存中获取最新传感器数据
           返回值:
                  true - 成功获取传感器最新数据
                  false - 获取最新数据失败
        */
        private bool FetchSensorData()
        {
            var sensorData = AppData.Data?["SensorData"] as SensorData;
            if (sensorData is not null)
            {
                Random rdn = new Random();
                
                // ...
            }

            return true;
        }
        // 根据获取的最新传感器数据计算对应实时数据
        private void DoCaculate()
        {
            // 计算综合测量区管道温度

            // 计算qQas

            // 计算V298	

            // 计算初始值
            if (_counter == 120)
            {

            }

            // 计算基准值
            if (_counter == 270)
            {

            }
            /* 120s以后才计算HRR和SPR,120s以前默认为0(因为此时还没有点火) */
            if (_counter > 120)
            {

            }
            else
            {

            }            
        }

        // 试验数据记录线程函数
        private void RecordData(object? status)
        {
            // 获取传感器最新数据,如果获取失败则跳过本轮,
            if (!FetchSensorData())
                return;

            // 保存传感器最新数据
            _sensorDataBuffer.Add(_sensorData);

            // 保存用于计算30s-90s初始值的数据
            if (_counter <= 90 && _counter >= 30)
            {

            }
            // 保存用于计算210s-270s基准值的数据
            if (_counter <= 270 && _counter >= 210)
            {

            }
            // 计算实时数据
            DoCaculate();

            /* 其他智能辅助性质的判断,目前尚不需要实现这些功能 */
            //判断当前供气时间是否超时
            //...
            //判断HRR是否过量
            //...
            //判断温度是否过高
            //...
            //判断有无设备故障
            //...

            // 计时器关键时间点相关处理(执行自动化控制、关键值计算等)
            if (_counter == 120)  // 点燃辅助燃烧器
            {
                ApparatusOperator.SetBurnerStatus(1, true);
            }
            else if (_counter == 270) // 关闭辅助燃烧器,开始主燃烧器点火倒计时提示
            {

            }
            else if (_counter == 300)  // 点燃主燃烧器,关闭辅助燃烧器
            {

            }
            else if (_counter == 900)  // 停止燃烧滴落物自动检测
            {

            }
            else if (_counter == 1560) // 停止试验,启动后续处理程序
            {

            }

            // 更新样品试验视图界面显示
            _viewModel.Counter = _counter;
            _view?.UpdateDisplay(_viewModel);

            // 增加采集计数器
            _counter++;
        }

        public void Start()
        {
            _timer.Change(0, 1000);
        }

        public void Stop()
        {
            _timer.Change(0, Timeout.Infinite);
        }

        // 判断初始试验条件

        // 判断试验终止条件

    }
}
