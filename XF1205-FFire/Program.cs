using Microsoft.Extensions.Configuration;

namespace XF1205_FFire
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            SensorData sensorData = new SensorData();
            ApparatusOperator apparatus = new ApparatusOperator();
            DataModel dataModel = new DataModel();
            Apparatus comport = new Apparatus();
            double delta = 0;

            // 获取配置文件对应项,并绑定至对应的Object instance
            try
            {
                IConfigurationRoot config = new ConfigurationBuilder()
                .AddJsonFile("config.json")
                .Build();

                config.GetSection("defaultvalue").Bind(dataModel);
                config.GetSection("apparatus").Bind(comport);
                delta = config.GetValue<double>("temperature");
            }
            catch (Exception e)
            {
                MessageBox.Show("应用程序配置项数据设置错误,请检查文件!\n" + e.Message, "系统异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }

            if (apparatus.EstablishConnection(comport.ComPortTemperature, comport.ComPortRelay))
            {
                // 启动试验设备数据采集
                apparatus.InitializeApparatus();
            }

            // 初始化应用程序全局存储
            AppData.Data = new Dictionary<string, object>();
            AppData.Data?.Add("SensorData", sensorData);
            AppData.Data?.Add("Apparatus", apparatus);
            AppData.Data?.Add("TestData", dataModel);
            // 为了应付计量局人员装怪的需求:允许手动设置温度测量的偏差值并自动体现到显示界面
            AppData.Data?.Add("Delta", delta);

            Application.Run(new MainForm());
        }
    }

    // 应用程序全局存储
    static class AppData
    {        public static Dictionary<string, object>? Data { get; set; }
    }
}