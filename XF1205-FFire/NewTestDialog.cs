
namespace XF1205_FFire
{
    public partial class NewTestDialog : Form
    {
        public NewTestDialog()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            double tmp = 0;
            DateTime tmpDate = DateTime.Now;
            Close();
            // 记录输入项
            var dataModel = AppData.Data?["TestData"] as DataModel;
            if (dataModel != null)
            {
                // 环境信息
                if (Double.TryParse(txtLabTemp.Text, out tmp))
                    dataModel.LabTemperature = tmp;
                if (Double.TryParse(txtLabHumidity.Text, out tmp))
                    dataModel.Humidity = tmp;
                // 样品信息
                dataModel.ProductName = txtProductName.Text;
                dataModel.SampleId = txtSampleId.Text;
                dataModel.TestId = txtTestId.Text;
                dataModel.ProductPrepareTime = txtSamplePrepareTime.Text;
                // 试验信息
                dataModel.ReportId = txtRptId.Text;
                dataModel.TestAccord = txtTestAccord.Text;
                if(DateTime.TryParse(txtTestDate.Text,out tmpDate))
                    dataModel.TestDate = tmpDate;
                dataModel.Operator = txtOperator.Text;
                // 设备信息
                dataModel.ApparatusCheckDate = txtApparatusCheckDate.Text;
                dataModel.ApparatusId = txtApparatusId.Text;
                dataModel.ApparatusName = txtApparatusName.Text;
                // 备注
                dataModel.Memo = txtTestMemo.Text;
            }
            Form frmTestForm = new TestForm();
            frmTestForm.Show();
        }

        private void NewTestDialog_Load(object sender, EventArgs e)
        {
            var dataModel = AppData.Data?["TestData"] as DataModel;
            if (dataModel != null)
            {
                txtLabTemp.Text = dataModel.LabTemperature.ToString();
                txtLabHumidity.Text = dataModel.Humidity.ToString();
                txtTestDate.Text = DateTime.Now.ToString("yyyy年MM月dd日");
                txtTestAccord.Text = dataModel.TestAccord;
                txtApparatusName.Text = dataModel.ApparatusName;
                txtApparatusId.Text = dataModel.ApparatusId;
                txtApparatusCheckDate.Text = dataModel.ApparatusCheckDate;
            }
        }

        private void txtSampleId_Leave(object sender, EventArgs e)
        {
            // 同步报告编号与样品编号
            txtRptId.Text = txtSampleId.Text;
        }

        private void btnClearInput_Click(object sender, EventArgs e)
        {
            txtSampleId.Text = string.Empty;
            txtRptId.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtTestId.Text = string.Empty;
            txtSamplePrepareTime.Text = string.Empty;
            txtOperator.Text = string.Empty;
            txtTestMemo.Text = string.Empty;
        }
    }
}
