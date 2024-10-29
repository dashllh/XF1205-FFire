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
            groupBox2 = new GroupBox();
            lblOilTemperatureDelta = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblOilTemperatuer);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(36, 25);
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
            btnClose.Location = new Point(132, 124);
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
            // groupBox2
            // 
            groupBox2.Controls.Add(lblOilTemperatureDelta);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(206, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(112, 73);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // lblOilTemperatureDelta
            // 
            lblOilTemperatureDelta.BackColor = Color.Black;
            lblOilTemperatureDelta.Dock = DockStyle.Bottom;
            lblOilTemperatureDelta.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblOilTemperatureDelta.ForeColor = Color.Yellow;
            lblOilTemperatureDelta.Location = new Point(3, 30);
            lblOilTemperatureDelta.Name = "lblOilTemperatureDelta";
            lblOilTemperatureDelta.Size = new Size(106, 40);
            lblOilTemperatureDelta.TabIndex = 1;
            lblOilTemperatureDelta.Text = "8888";
            lblOilTemperatureDelta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 11);
            label3.Name = "label3";
            label3.Size = new Size(102, 17);
            label3.TabIndex = 0;
            label3.Text = "升温速率(℃/min)";
            // 
            // SystemStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 176);
            Controls.Add(groupBox2);
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
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label lblOilTemperatuer;
        private Button btnClose;
        private System.Windows.Forms.Timer timerSystemStatus;
        private GroupBox groupBox2;
        private Label lblOilTemperatureDelta;
        private Label label3;
    }
}