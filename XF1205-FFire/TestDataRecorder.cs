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
        // 样品数据模型
        private DataModel _dataModel;
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
            _dataModel = new();
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
                _viewModel.SensorData.OilTemperature = sensorData.OilTemperature;
            }

            return true;
        }
        // 根据获取的最新传感器数据计算对应实时数据
        private void DoCaculate()
        {
            // 计算当前温度升高速度
            // ...
        }

        // 试验数据记录线程函数
        private void RecordData(object? status)
        {
            // 获取传感器最新数据,如果获取失败则跳过本轮,
            if (!FetchSensorData())
                return;

            // 保存传感器最新数据
            _sensorDataBuffer.Add(_sensorData);

            // 计算实时数据
            DoCaculate();
            
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

        public void OutputTestData()
        {
            /* 创建本地存储目录 */
            //string prodpath = $"D:\\ISO11820\\{_testmaster.Productid}";
            //string smppath = $"{prodpath}\\{_testmaster.Testid}";
            //string datapath = $"{smppath}\\data";
            //string rptpath = $"{smppath}\\report";
            // 重置试验控制变量
            _counter = 0;
        }
    }
}
