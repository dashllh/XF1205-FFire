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
            Apparatus comport = new Apparatus();

            // ��ȡ�����ļ���Ӧ��,��������Ӧ��Object instance
            config.GetSection("defaultvalue").Bind(dataModel);
            config.GetSection("apparatus").Bind(comport);

            if (apparatus.EstablishConnection(comport.ComPortTemperature, comport.ComPortRelay))
            {
                // ���������豸���ݲɼ�
                apparatus.InitializeApparatus();
            }            
            // ��ʼ��Ӧ�ó���ȫ�ִ洢
            AppData.Data = new Dictionary<string, object>();
            AppData.Data?.Add("SensorData", sensorData);
            AppData.Data?.Add("Apparatus", apparatus);
            AppData.Data?.Add("TestData", dataModel);


            Application.Run(new MainForm());
        }
    }

    // Ӧ�ó���ȫ�ִ洢
    static class AppData
    {        public static Dictionary<string, object>? Data { get; set; }
    }
}