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

            // ��ȡ�����ļ���Ӧ��,��������Ӧ��Object instance
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
                MessageBox.Show("Ӧ�ó����������������ô���,�����ļ�!\n" + e.Message, "ϵͳ�쳣", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }

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
            // Ϊ��Ӧ����������Աװ�ֵ�����:�����ֶ������¶Ȳ�����ƫ��ֵ���Զ����ֵ���ʾ����
            AppData.Data?.Add("Delta", delta);

            Application.Run(new MainForm());
        }
    }

    // Ӧ�ó���ȫ�ִ洢
    static class AppData
    {        public static Dictionary<string, object>? Data { get; set; }
    }
}