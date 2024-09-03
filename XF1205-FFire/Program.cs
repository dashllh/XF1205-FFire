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

            IConfigurationRoot config = new ConfigurationBuilder()
                .AddJsonFile("config.json")
                .Build();

            SensorData sensorData = new SensorData();
            ApparatusOperator apparatus = new ApparatusOperator();
            DataModel dataModel = new DataModel();

            // 获取配置文件对应项,并绑定至对应的Object instance
            config.GetSection("defaultvalue").Bind(dataModel);

            if (apparatus.EstablishConnection("COM2","COM3"))
            {
                // 启动试验设备数据采集
                apparatus.InitializeApparatus();
            }            
            // 初始化应用程序全局存储
            AppData.Data = new Dictionary<string, object>();
            AppData.Data?.Add("SensorData", sensorData);
            AppData.Data?.Add("Apparatus", apparatus);
            AppData.Data?.Add("TestData", dataModel);


            Application.Run(new MainForm());
        }
    }

    // 应用程序全局存储
    static class AppData
    {
        public static Dictionary<string, object>? Data { get; set; }
    }
}