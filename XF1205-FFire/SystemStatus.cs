namespace XF1205_FFire
{
    public partial class SystemStatus : Form
    {
        private readonly System.Threading.Timer _timer;
        // 前一分钟的油面瞬时温度
        private double _oilTempPre;
        // 当前油面温度
        private double _oilTemperature;
        public SystemStatus()
        {
            InitializeComponent();
            _timer = new(RefreshDeltaTemperature);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            timerSystemStatus.Stop();
            _timer.Change(0,Timeout.Infinite);
            _timer.Dispose();
            Close();
        }

        private void timerSystemStatus_Tick(object sender, EventArgs e)
        {            
            // 使用窗体计时器刷新油面温度显示以及升温速率
            var sensorData = AppData.Data?["SensorData"] as SensorData;
            // 从传感器取得当前最新油面温度值
            _oilTemperature = sensorData?.OilTemperature ?? 0.0;
            lblOilTemperatuer.Text = _oilTemperature.ToString("0.0");
        }

        private void RefreshDeltaTemperature(object? status)
        {
            // 计算当前升温速率
            Invoke(new System.Action(() =>
            {
                lblOilTemperatureDelta.Text = ((_oilTemperature - _oilTempPre).ToString("0.0"));
            }));
            // 保存当前油面温度为上一分钟的温度
            _oilTempPre = _oilTemperature;
        }

        private void SystemStatus_Load(object sender, EventArgs e)
        {
            // 从传感器取得当前最新油面温度值
            var sensorData = AppData.Data?["SensorData"] as SensorData;
            // 初始化"上一分钟"的油面温度
            _oilTempPre = sensorData?.OilTemperature ?? 0.0;
            timerSystemStatus.Start();
            _timer.Change(TimeSpan.FromMinutes(1.0), TimeSpan.FromMinutes(1.0));
        }
    }
}
