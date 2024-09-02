namespace XF1205_FFire
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            Form dlgAbout = new AboutDialog();
            dlgAbout.ShowDialog();
        }

        private void btnCalibration_Click(object sender, EventArgs e)
        {
            Form frmCalibration = new CalibratoinForm();
            frmCalibration.Show();
        }

        private void btnNewTest_Click(object sender, EventArgs e)
        {
            Form dlgNewTest = new NewTestDialog();
            dlgNewTest.ShowDialog();
        }
    }
}
