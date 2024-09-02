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
            if (apparatus.EstablishConnection("COM2","COM3"))
            {
                // 启动试验设备数据采集
                apparatus.InitializeApparatus();
            }            
            // 初始化应用程序全局存储
            AppData.Data = new Dictionary<string, object>();
            AppData.Data?.Add("SensorData", sensorData);
            AppData.Data?.Add("Apparatus", apparatus);            

            Application.Run(new MainForm());
        }
    }

    // 应用程序全局存储
    static class AppData
    {
        public static Dictionary<string, object>? Data { get; set; }
    }
}