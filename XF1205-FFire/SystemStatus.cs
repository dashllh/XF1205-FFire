namespace XF1205_FFire
{
    public partial class SystemStatus : Form
    {        
        public SystemStatus()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            timerSystemStatus.Stop();
            Close();
        }

        private void timerSystemStatus_Tick(object sender, EventArgs e)
        {            
            // 使用窗体计时器刷新油面温度显示以及升温速率
            var sensorData = AppData.Data?["SensorData"] as SensorData;
            // 从传感器取得当前最新油面温度值
            lblOilTemperatuer.Text = (sensorData?.OilTemperature ?? 0.0).ToString("0.0");
        }

        private void SystemStatus_Load(object sender, EventArgs e)
        {
            // 开启温度刷新计时器
            timerSystemStatus.Start();
        }
    }
}
