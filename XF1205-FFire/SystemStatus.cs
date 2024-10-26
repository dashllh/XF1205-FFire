using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            var sensorData = AppData.Data?["SensorData"] as SensorData;
            lblOilTemperatuer.Text = sensorData?.OilTemperature.ToString("0.0");
        }

        private void SystemStatus_Load(object sender, EventArgs e)
        {
            timerSystemStatus.Start();
        }
    }
}
