
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
            if (txtSampleId.Text == string.Empty)
            {
                MessageBox.Show("样品编号不能为空。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSampleId.Focus();
                return;
            }

            if (txtTestId.Text == string.Empty)
            {
                MessageBox.Show("样品标识号不能为空。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTestId.Focus();
                return;
            }

            if (rdoAddress2.Checked && txtOtherTestAddress.Text.Trim() == string.Empty)
            {
                // 提示用户输入试验地址
                MessageBox.Show("请输入其他试验地点。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOtherTestAddress.Focus();
                return;
            }

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
                if (DateTime.TryParse(txtTestDate.Text, out tmpDate))
                    dataModel.TestDate = tmpDate;
                dataModel.Operator = txtOperator.Text;
                // 设备信息
                dataModel.ApparatusCheckDate = txtApparatusCheckDate.Text;
                dataModel.ApparatusId = txtApparatusId.Text;
                dataModel.ApparatusName = txtApparatusName.Text;
                // 备注
                //dataModel.Memo = txtTestMemo.Text;
                // 试验地址
                if (rdoAddress1.Checked)
                {
                    dataModel.TestAddressOption = "1";
                    dataModel.OtherTestAddress = string.Empty;
                }
                if (rdoAddress2.Checked)
                {
                    dataModel.TestAddressOption = "2";
                    dataModel.OtherTestAddress = txtOtherTestAddress.Text;
                }
            }
            TestForm frmTestForm = new TestForm();
            frmTestForm.Show();
            // 启动数据记录及曲线显示
            //frmTestForm.StartCharting();
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

                txtProductName.Text = dataModel.ProductName;
                txtSampleId.Text = dataModel.SampleId;
                txtSamplePrepareTime.Text = dataModel.ProductPrepareTime;
                txtOperator.Text = dataModel.Operator;
                txtRptId.Text = dataModel.ReportId;
                txtTestMemo.Text = dataModel.Memo;
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

        private void rdoAddress2_CheckedChanged(object sender, EventArgs e)
        {
            txtOtherTestAddress.Enabled = rdoAddress2.Checked;
        }
    }
}
