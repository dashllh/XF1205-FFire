
using DevExpress.XtraSpreadsheet.Model;
using Microsoft.Office.Interop.Excel;
using System;

namespace XF1205_FFire
{
    public partial class TestForm : Form
    {
        private int _counter;
        private TestDataRecorder recorder;
        //private ApparatusOperator apparatusOperator;
        // 前一分钟的油面瞬时温度
        private double _oilTempPre;
        // 当前油面温度
        private double _oilTemperature;
        public TestForm()
        {
            InitializeComponent();
            _counter = 0;
            recorder = new TestDataRecorder();
            recorder.BindView(this);
            //apparatusOperator = AppData.Data?["Apparatus"] as ApparatusOperator ?? new ApparatusOperator();
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("关闭试验对话框会退出当前试验,数据无法保存,是否继续？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                recorder.Stop();
                Close();
            }
        }

        // 开始2Min计时
        private void btnStartTest_Click(object sender, EventArgs e)
        {
            // 启动界面计时器,只负责更新并显示计时值
            _counter = 0;
            timer_counting.Start();
            btnStartTest.Enabled = false;
            btnStopTest.Enabled = true;
            // 开始计时后才允许点击生成报表按钮,避免因List对象不支持多线程操作而引起系统异常
            btnGenerateReport.Enabled = true;
        }

        private void btnStopTest_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("确定停止本次试验吗?", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                // 停止界面计时更新
                timer_counting.Stop();
                btnStartTest.Enabled = true;
                btnStopTest.Enabled = false;
            }
        }

        private void btnOpenValve_Click(object sender, EventArgs e)
        {
            var apparatus = AppData.Data?["Apparatus"] as ApparatusOperator;
            bool? ret = apparatus?.SetValveStatus(1).Item1;
            if (ret.HasValue && ret == true)
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

        public void UpdateDisplay(TestViewModel model)
        {
            try
            {
                Invoke(new System.Action(() =>
                {
                    // 开始记录升温数据,但不更新计时器显示,计时器显示由独立的变量控制
                    // 更新升温计时器显示值
                    lblHeatTime.Text = model.Counter.ToString();
                    // 更新油面温度显示值
                    lblOilTemperature.Text = model.SensorData.OilTemperature.ToString("0.0");
                    // 更新温度曲线显示
                    chartOilTemp.Series[0].Points.AddXY(model.Counter, model.SensorData.OilTemperature);
                    // 300秒后开始平移曲线图坐标轴
                    if (model.Counter > 300)
                    {
                        chartOilTemp.ChartAreas[0].AxisX.Minimum = model.Counter - 300;
                        chartOilTemp.ChartAreas[0].AxisX.Maximum = model.Counter;
                    }
                    // 按60秒频率更新油面温度变化值
                    if(model.Counter >= 60 && model.Counter % 60 == 0)
                    {
                        lblOilTemperatureDelta.Text = ((_oilTemperature - _oilTempPre).ToString("0.0"));
                        // 保存当前油面温度为上一分钟的温度
                        _oilTempPre = _oilTemperature;
                    }
                }));
            }
            catch (InvalidOperationException)
            {
            }
        }
        public void ResetDisplay()
        {
            Invoke(new System.Action(() =>
            {
                lblTimer.Text = "0";
                lblOilTemperature.Text = "8888";
                lblHeatTime.Text = "0";
                lblOilTemperatureDelta.Text = "8888";
                chartOilTemp.Series[0].Points.Clear();
            }));
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            recorder.OutputTestData();
        }

        private void rdoOK1_CheckedChanged(object sender, EventArgs e)
        {
            DataModel? dataModel = AppData.Data?["TestData"] as DataModel;
            if (dataModel != null)
            {
                dataModel.Result1 = rdoOK1.Checked ? true : false;
            }
        }

        private void rdoNG1_CheckedChanged(object sender, EventArgs e)
        {
            DataModel? dataModel = AppData.Data?["TestData"] as DataModel;
            if (dataModel != null)
            {
                dataModel.Result1 = rdoNG1.Checked ? false : true;
            }
        }
        private void rdoOK2_CheckedChanged(object sender, EventArgs e)
        {
            DataModel? dataModel = AppData.Data?["TestData"] as DataModel;
            if (dataModel != null)
            {
                dataModel.Result2 = rdoOK2.Checked ? true : false;
            }
        }

        private void rdoNG2_CheckedChanged(object sender, EventArgs e)
        {
            DataModel? dataModel = AppData.Data?["TestData"] as DataModel;
            if (dataModel != null)
            {
                dataModel.Result2 = rdoNG2.Checked ? false : true;
            }
        }

        private void rdoOK3_CheckedChanged(object sender, EventArgs e)
        {
            DataModel? dataModel = AppData.Data?["TestData"] as DataModel;
            if (dataModel != null)
            {
                dataModel.Result3 = rdoOK3.Checked ? true : false;
            }
        }

        private void rdoNG3_CheckedChanged(object sender, EventArgs e)
        {
            DataModel? dataModel = AppData.Data?["TestData"] as DataModel;
            if (dataModel != null)
            {
                dataModel.Result3 = rdoNG3.Checked ? false : true;
            }
        }

        private void txtNGReason1_Leave(object sender, EventArgs e)
        {
            DataModel? dataModel = AppData.Data?["TestData"] as DataModel;
            if (dataModel != null)
            {
                dataModel.NGReason1 = txtNGReason1.Text;
            }
        }

        private void txtNGReason2_Leave(object sender, EventArgs e)
        {
            DataModel? dataModel = AppData.Data?["TestData"] as DataModel;
            if (dataModel != null)
            {
                dataModel.NGReason2 = txtNGReason2.Text;
            }
        }

        private void txtNGReason3_Leave(object sender, EventArgs e)
        {
            DataModel? dataModel = AppData.Data?["TestData"] as DataModel;
            if (dataModel != null)
            {
                dataModel.NGReason3 = txtNGReason3.Text;
            }
        }
        private void timer_counting_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = _counter.ToString();
            _counter++;
        }

        private void btnStartHeat_Click(object sender, EventArgs e)
        {
            // 开始记录温度数据
            recorder.Start();
            btnStartHeat.Enabled = false;   
            btnStopHeat.Enabled = true;
        }

        private void btnStopHeat_Click(object sender, EventArgs e)
        {
            // 停止温度数据记录
            recorder.Stop();
            btnStartHeat.Enabled = true;
            btnStopHeat.Enabled = false;
        }
    }
}
