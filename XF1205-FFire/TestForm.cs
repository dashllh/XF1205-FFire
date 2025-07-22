
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
                btnCloseValve.Focus();
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
                btnOpenValve.Focus();
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
                    _oilTemperature = model.SensorData.OilTemperature;
                    lblOilTemperature.Text = model.SensorData.OilTemperature.ToString("0.0");
                    // 更新温度曲线显示
                    chartOilTemp.Series[0].Points.AddXY(model.Counter, model.SensorData.OilTemperature);
                    // 300秒后开始平移曲线图坐标轴
                    if (model.Counter > 300)
                    {
                        chartOilTemp.ChartAreas[0].AxisX.Minimum = model.Counter - 300;
                        chartOilTemp.ChartAreas[0].AxisX.Maximum = model.Counter;
                    }
                    // 0秒时刻记录前一分钟温度值
                    if (model.Counter == 0)
                    {
                        _oilTempPre = _oilTemperature;
                    }
                    // 按60秒频率更新油面温度变化值
                    if (model.Counter >= 60 && model.Counter % 60 == 0)
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
                lblTimer.Text = "8888";
                lblOilTemperature.Text = "8888";
                lblHeatTime.Text = "8888";
                lblOilTemperatureDelta.Text = "8888";
                // 清空曲线数据
                chartOilTemp.Series[0].Points.Clear();
                rdoOK1.Checked = false;
                rdoNG1.Checked = false;
                rdoOK2.Checked = false;
                rdoNG2.Checked = false;
                rdoOK3.Checked = false;
                rdoNG3.Checked = false;
                rdoOKFinalResult.Checked = false;
                rdoNGFinalResult.Checked = false;
                // 清空试验记录
                txtNGReason1.Text = string.Empty;
                txtNGReason2.Text = string.Empty;
                txtNGReason3.Text = string.Empty;
                txtNGReasonFinalResult.Text = string.Empty;
                // 设置生成报表按钮无效
                btnGenerateReport.Enabled = false;
            }));
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            // 检查试验记录及结论是否录入完整
            if(!rdoOKFinalResult.Checked && !rdoNGFinalResult.Checked)
            {
                MessageBox.Show("请录入试验结论!", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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

        private void rdoOKFinalResult_CheckedChanged(object sender, EventArgs e)
        {
            DataModel? dataModel = AppData.Data?["TestData"] as DataModel;
            if (dataModel != null)
            {
                dataModel.FinalResult = rdoOKFinalResult.Checked ? true : false;
            }
            if(rdoOKFinalResult.Checked)
            {
                txtNGReasonFinalResult.Enabled = false;
            }
        }
        private void rdoNGFinalResult_CheckedChanged(object sender, EventArgs e)
        {
            DataModel? dataModel = AppData.Data?["TestData"] as DataModel;
            if (dataModel != null)
            {
                dataModel.FinalResult = rdoNGFinalResult.Checked ? false : true;
            }
            if (rdoNGFinalResult.Checked)
            {
                txtNGReasonFinalResult.Enabled = true;
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
        private void txtNGReasonFinalResult_Leave(object sender, EventArgs e)
        {
            // 保存最终结果的NG原因
            DataModel? dataModel = AppData.Data?["TestData"] as DataModel;
            if (dataModel != null)
            {
                dataModel.NGFinalReason = txtNGReasonFinalResult.Text;
            }
        }
        private void timer_counting_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = _counter.ToString();
            _counter++;
        }

        // 启动升温计时
        private void btnStartHeat_Click(object sender, EventArgs e)
        {
            // 重置当前温度与前一分钟温度值
            _oilTemperature = 0;
            _oilTempPre = 0;
            // 重置实时值显示
            lblHeatTime.Text = "8888";
            lblOilTemperatureDelta.Text = "8888";
            // 清空温度曲线数据记录
            chartOilTemp.Series[0].Points.Clear();
            // 开始记录温度数据
            recorder.Start();
            btnStartHeat.Enabled = false;
            btnStopHeat.Enabled = true;
            btnStopHeat.Focus();
        }

        // 停止升温计时
        private void btnStopHeat_Click(object sender, EventArgs e)
        {
            // 停止温度数据记录
            recorder.Stop();
            btnStartHeat.Enabled = true;
            btnStopHeat.Enabled = false;
            btnStartHeat.Focus();
        }        
    }
}
