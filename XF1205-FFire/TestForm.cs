﻿using System;
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
    public partial class TestForm : Form
    {
        private TestDataRecorder recorder;
        private ApparatusOperator apparatusOperator;
        public TestForm()
        {
            InitializeComponent();
            recorder = new TestDataRecorder();
            recorder.BindView(this);
            apparatusOperator = new ApparatusOperator();
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            recorder.Start();
        }

        private void btnStopTest_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("确定停止本次试验吗?", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                recorder.Stop();
                // 重置试验界面显示
                ResetDisplay();
            }                
        }

        private void btnOpenValve_Click(object sender, EventArgs e)
        {
            var apparatus = AppData.Data?["Apparatus"] as ApparatusOperator;
            bool? ret = apparatus?.SetValveStatus(1).Item1;
            if(ret.HasValue && ret == true)
            {
                btnOpenValve.Enabled = false;
                btnCloseValve.Enabled = true;
            }            
        }

        private void btnCloseValve_Click(object sender, EventArgs e)
        {
            var apparatus = AppData.Data?["Apparatus"] as ApparatusOperator;            
            bool? ret = apparatus?.SetValveStatus(0).Item1;
            if (ret.HasValue && ret == true)
            {
                btnOpenValve.Enabled = true;
                btnCloseValve.Enabled = false;
            }            
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            
        }

        public void UpdateDisplay(TestViewModel model)
        {
            try
            {
                this.Invoke(new Action(() =>
                {
                    lblTimer.Text = model.Counter.ToString();
                    chartOilTemp.Series[0].Points.AddXY(model.Counter, model.SensorData.OilTemperature);
                    // 300秒后开始平移曲线图坐标轴
                    if (model.Counter > 300)
                    {
                        chartOilTemp.ChartAreas[0].AxisX.Minimum = model.Counter - 300;
                        chartOilTemp.ChartAreas[0].AxisX.Maximum = model.Counter;
                    }
                    
                }));
            }
            catch (InvalidOperationException)
            {

            }
        }

        private void ResetDisplay()
        {
            lblTimer.Text = "0";
            lblOilTemperature.Text = "8888";
            chartOilTemp.Series[0].Points.Clear();
        }
    }
}
