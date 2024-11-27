namespace XF1205_FFire
{
    partial class SystemStatus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            lblOilTemperatuer = new Label();
            label1 = new Label();
            btnClose = new Button();
            timerSystemStatus = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblOilTemperatuer);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(114, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(112, 73);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // lblOilTemperatuer
            // 
            lblOilTemperatuer.BackColor = Color.Black;
            lblOilTemperatuer.Dock = DockStyle.Bottom;
            lblOilTemperatuer.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblOilTemperatuer.ForeColor = Color.Yellow;
            lblOilTemperatuer.Location = new Point(3, 30);
            lblOilTemperatuer.Name = "lblOilTemperatuer";
            lblOilTemperatuer.Size = new Size(106, 40);
            lblOilTemperatuer.TabIndex = 1;
            lblOilTemperatuer.Text = "8888";
            lblOilTemperatuer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 11);
            label1.Name = "label1";
            label1.Size = new Size(76, 17);
            label1.TabIndex = 0;
            label1.Text = "油面温度(℃)";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(127, 116);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(86, 33);
            btnClose.TabIndex = 1;
            btnClose.Text = "关闭";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // timerSystemStatus
            // 
            timerSystemStatus.Interval = 1000;
            timerSystemStatus.Tick += timerSystemStatus_Tick;
            // 
            // SystemStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 172);
            Controls.Add(btnClose);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "SystemStatus";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "系统状态";
            TopMost = true;
            Load += SystemStatus_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label lblOilTemperatuer;
        private Button btnClose;
        private System.Windows.Forms.Timer timerSystemStatus;
    }
}