
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
            Close();
            Form frmTestForm = new TestForm();
            frmTestForm.Show();
        }

        private void NewTestDialog_Load(object sender, EventArgs e)
        {
            var dataModel = AppData.Data?["TestData"] as DataModel;
            if(dataModel != null)
            {
                txtLabTemp.Text = dataModel.LabTemperature.ToString();
                txtLabHumidity.Text = dataModel.Humidity.ToString();
            }            
        }
    }
}
