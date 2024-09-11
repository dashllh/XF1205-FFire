namespace XF1205_FFire
{
    partial class TestForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBox1 = new GroupBox();
            lblTimer = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lblOilTemperature = new Label();
            label3 = new Label();
            groupBox6 = new GroupBox();
            panel3 = new Panel();
            rdoNG3 = new RadioButton();
            rdoOK3 = new RadioButton();
            panel2 = new Panel();
            rdoNG2 = new RadioButton();
            rdoOK2 = new RadioButton();
            panel1 = new Panel();
            rdoNG1 = new RadioButton();
            rdoOK1 = new RadioButton();
            txtNGReason3 = new TextBox();
            txtNGReason2 = new TextBox();
            txtNGReason1 = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            btnStartTest = new Button();
            btnStopTest = new Button();
            chartOilTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnOpenValve = new Button();
            btnCloseValve = new Button();
            btnGenerateReport = new Button();
            btnCloseWindow = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox6.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartOilTemp).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTimer);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(24, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(105, 75);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // lblTimer
            // 
            lblTimer.BackColor = Color.Black;
            lblTimer.Dock = DockStyle.Bottom;
            lblTimer.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTimer.ForeColor = Color.Yellow;
            lblTimer.Location = new Point(3, 30);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(99, 42);
            lblTimer.TabIndex = 1;
            lblTimer.Text = "8888";
            lblTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 12);
            label1.Name = "label1";
            label1.Size = new Size(70, 17);
            label1.TabIndex = 0;
            label1.Text = "试验计时(s)";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblOilTemperature);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(24, 100);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(105, 75);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // lblOilTemperature
            // 
            lblOilTemperature.BackColor = Color.Black;
            lblOilTemperature.Dock = DockStyle.Bottom;
            lblOilTemperature.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblOilTemperature.ForeColor = Color.Yellow;
            lblOilTemperature.Location = new Point(3, 30);
            lblOilTemperature.Name = "lblOilTemperature";
            lblOilTemperature.Size = new Size(99, 42);
            lblOilTemperature.TabIndex = 1;
            lblOilTemperature.Text = "8888";
            lblOilTemperature.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 12);
            label3.Name = "label3";
            label3.Size = new Size(76, 17);
            label3.TabIndex = 0;
            label3.Text = "油面温度(℃)";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(panel3);
            groupBox6.Controls.Add(panel2);
            groupBox6.Controls.Add(panel1);
            groupBox6.Controls.Add(txtNGReason3);
            groupBox6.Controls.Add(txtNGReason2);
            groupBox6.Controls.Add(txtNGReason1);
            groupBox6.Controls.Add(label16);
            groupBox6.Controls.Add(label15);
            groupBox6.Controls.Add(label14);
            groupBox6.Location = new Point(27, 397);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(675, 136);
            groupBox6.TabIndex = 14;
            groupBox6.TabStop = false;
            groupBox6.Text = "检验项目及结果";
            // 
            // panel3
            // 
            panel3.Controls.Add(rdoNG3);
            panel3.Controls.Add(rdoOK3);
            panel3.Location = new Point(261, 98);
            panel3.Name = "panel3";
            panel3.Size = new Size(243, 32);
            panel3.TabIndex = 14;
            // 
            // rdoNG3
            // 
            rdoNG3.AutoSize = true;
            rdoNG3.Location = new Point(90, 6);
            rdoNG3.Name = "rdoNG3";
            rdoNG3.Size = new Size(149, 21);
            rdoNG3.TabIndex = 10;
            rdoNG3.TabStop = true;
            rdoNG3.Text = "不符合要求，补充说明:";
            rdoNG3.UseVisualStyleBackColor = true;
            rdoNG3.CheckedChanged += rdoNG3_CheckedChanged;
            // 
            // rdoOK3
            // 
            rdoOK3.AutoSize = true;
            rdoOK3.Location = new Point(9, 6);
            rdoOK3.Name = "rdoOK3";
            rdoOK3.Size = new Size(74, 21);
            rdoOK3.TabIndex = 9;
            rdoOK3.TabStop = true;
            rdoOK3.Text = "符合要求";
            rdoOK3.UseVisualStyleBackColor = true;
            rdoOK3.CheckedChanged += rdoOK3_CheckedChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(rdoNG2);
            panel2.Controls.Add(rdoOK2);
            panel2.Location = new Point(262, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(242, 27);
            panel2.TabIndex = 13;
            // 
            // rdoNG2
            // 
            rdoNG2.AutoSize = true;
            rdoNG2.Location = new Point(89, 3);
            rdoNG2.Name = "rdoNG2";
            rdoNG2.Size = new Size(149, 21);
            rdoNG2.TabIndex = 9;
            rdoNG2.TabStop = true;
            rdoNG2.Text = "不符合要求，补充说明:";
            rdoNG2.UseVisualStyleBackColor = true;
            rdoNG2.CheckedChanged += rdoNG2_CheckedChanged;
            // 
            // rdoOK2
            // 
            rdoOK2.AutoSize = true;
            rdoOK2.Location = new Point(8, 3);
            rdoOK2.Name = "rdoOK2";
            rdoOK2.Size = new Size(74, 21);
            rdoOK2.TabIndex = 8;
            rdoOK2.TabStop = true;
            rdoOK2.Text = "符合要求";
            rdoOK2.UseVisualStyleBackColor = true;
            rdoOK2.CheckedChanged += rdoOK2_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(rdoNG1);
            panel1.Controls.Add(rdoOK1);
            panel1.Location = new Point(262, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 35);
            panel1.TabIndex = 12;
            // 
            // rdoNG1
            // 
            rdoNG1.AutoSize = true;
            rdoNG1.Location = new Point(88, 7);
            rdoNG1.Name = "rdoNG1";
            rdoNG1.Size = new Size(149, 21);
            rdoNG1.TabIndex = 8;
            rdoNG1.TabStop = true;
            rdoNG1.Text = "不符合要求，补充说明:";
            rdoNG1.UseVisualStyleBackColor = true;
            rdoNG1.CheckedChanged += rdoNG1_CheckedChanged;
            // 
            // rdoOK1
            // 
            rdoOK1.AutoSize = true;
            rdoOK1.Location = new Point(8, 7);
            rdoOK1.Name = "rdoOK1";
            rdoOK1.Size = new Size(74, 21);
            rdoOK1.TabIndex = 7;
            rdoOK1.TabStop = true;
            rdoOK1.Text = "符合要求";
            rdoOK1.UseVisualStyleBackColor = true;
            rdoOK1.CheckedChanged += rdoOK1_CheckedChanged;
            // 
            // txtNGReason3
            // 
            txtNGReason3.Location = new Point(510, 104);
            txtNGReason3.Name = "txtNGReason3";
            txtNGReason3.Size = new Size(144, 23);
            txtNGReason3.TabIndex = 11;
            txtNGReason3.Leave += txtNGReason3_Leave;
            // 
            // txtNGReason2
            // 
            txtNGReason2.Location = new Point(510, 68);
            txtNGReason2.Name = "txtNGReason2";
            txtNGReason2.Size = new Size(144, 23);
            txtNGReason2.TabIndex = 10;
            txtNGReason2.Leave += txtNGReason2_Leave;
            // 
            // txtNGReason1
            // 
            txtNGReason1.Location = new Point(510, 31);
            txtNGReason1.Name = "txtNGReason1";
            txtNGReason1.Size = new Size(144, 23);
            txtNGReason1.TabIndex = 9;
            txtNGReason1.Leave += txtNGReason1_Leave;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(21, 105);
            label16.Name = "label16";
            label16.Size = new Size(240, 17);
            label16.TabIndex = 2;
            label16.Text = "移开灭火毯后3min内油盘中残油不再自燃。";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(21, 70);
            label15.Name = "label15";
            label15.Size = new Size(248, 17);
            label15.TabIndex = 1;
            label15.Text = "移开灭火毯后看不到火焰且油盘中还有残油。";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(21, 33);
            label14.Name = "label14";
            label14.Size = new Size(248, 17);
            label14.TabIndex = 0;
            label14.Text = "在试验过程中，灭火毯保持完整，不被烧穿。";
            // 
            // btnStartTest
            // 
            btnStartTest.Location = new Point(24, 193);
            btnStartTest.Name = "btnStartTest";
            btnStartTest.Size = new Size(105, 34);
            btnStartTest.TabIndex = 15;
            btnStartTest.Text = "开始计时";
            btnStartTest.UseVisualStyleBackColor = true;
            btnStartTest.Click += btnStartTest_Click;
            // 
            // btnStopTest
            // 
            btnStopTest.Enabled = false;
            btnStopTest.Location = new Point(24, 243);
            btnStopTest.Name = "btnStopTest";
            btnStopTest.Size = new Size(105, 34);
            btnStopTest.TabIndex = 16;
            btnStopTest.Text = "停止计时";
            btnStopTest.UseVisualStyleBackColor = true;
            btnStopTest.Click += btnStopTest_Click;
            // 
            // chartOilTemp
            // 
            chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea1.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.Position;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.None;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.Interval = 60D;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.LabelStyle.ForeColor = Color.Gray;
            chartArea1.AxisX.LineColor = Color.LightGray;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea1.AxisX.MajorTickMark.LineColor = Color.Gray;
            chartArea1.AxisX.Maximum = 300D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.MinorTickMark.LineColor = Color.Gray;
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.LabelStyle.ForeColor = Color.Gray;
            chartArea1.AxisY.LineColor = Color.Transparent;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartArea1.AxisY.MajorTickMark.LineColor = Color.LightGray;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.MinorGrid.LineColor = Color.LightGray;
            chartArea1.AxisY.MinorTickMark.LineColor = Color.LightGray;
            chartArea1.AxisY.Title = "油温(℃)";
            chartArea1.AxisY.TitleFont = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            chartArea1.AxisY.TitleForeColor = Color.Gray;
            chartArea1.BackColor = Color.Black;
            chartArea1.BorderColor = Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chartOilTemp.ChartAreas.Add(chartArea1);
            legend1.BackColor = Color.Transparent;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.ForeColor = Color.Gray;
            legend1.Name = "legendOilTemp";
            legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide;
            legend1.TitleForeColor = Color.Transparent;
            chartOilTemp.Legends.Add(legend1);
            chartOilTemp.Location = new Point(149, 29);
            chartOilTemp.Name = "chartOilTemp";
            series1.BorderColor = Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = Color.Firebrick;
            series1.Legend = "legendOilTemp";
            series1.LegendText = "油温";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            chartOilTemp.Series.Add(series1);
            chartOilTemp.Size = new Size(694, 348);
            chartOilTemp.TabIndex = 17;
            chartOilTemp.Text = "chart1";
            // 
            // btnOpenValve
            // 
            btnOpenValve.Location = new Point(24, 293);
            btnOpenValve.Name = "btnOpenValve";
            btnOpenValve.Size = new Size(105, 34);
            btnOpenValve.TabIndex = 18;
            btnOpenValve.Text = "打开燃气阀";
            btnOpenValve.UseVisualStyleBackColor = true;
            btnOpenValve.Click += btnOpenValve_Click;
            // 
            // btnCloseValve
            // 
            btnCloseValve.Enabled = false;
            btnCloseValve.Location = new Point(24, 343);
            btnCloseValve.Name = "btnCloseValve";
            btnCloseValve.Size = new Size(105, 34);
            btnCloseValve.TabIndex = 19;
            btnCloseValve.Text = "关闭燃气阀";
            btnCloseValve.UseVisualStyleBackColor = true;
            btnCloseValve.Click += btnCloseValve_Click;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(717, 417);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(126, 42);
            btnGenerateReport.TabIndex = 20;
            btnGenerateReport.Text = "生成试验报告";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // btnCloseWindow
            // 
            btnCloseWindow.Location = new Point(717, 475);
            btnCloseWindow.Name = "btnCloseWindow";
            btnCloseWindow.Size = new Size(126, 42);
            btnCloseWindow.TabIndex = 21;
            btnCloseWindow.Text = "关闭";
            btnCloseWindow.UseVisualStyleBackColor = true;
            btnCloseWindow.Click += btnCloseWindow_Click;
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 548);
            Controls.Add(btnCloseWindow);
            Controls.Add(btnGenerateReport);
            Controls.Add(btnCloseValve);
            Controls.Add(btnOpenValve);
            Controls.Add(chartOilTemp);
            Controls.Add(btnStopTest);
            Controls.Add(btnStartTest);
            Controls.Add(groupBox6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TestForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "样品试验";
            TopMost = true;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartOilTemp).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblTimer;
        private Label label1;
        private GroupBox groupBox2;
        private Label lblOilTemperature;
        private Label label3;
        private GroupBox groupBox6;
        private TextBox txtNGReason3;
        private TextBox txtNGReason2;
        private TextBox txtNGReason1;
        private Label label16;
        private Label label15;
        private Label label14;
        private Button btnStartTest;
        private Button btnStopTest;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOilTemp;
        private Button btnOpenValve;
        private Button btnCloseValve;
        private Button btnGenerateReport;
        private Button btnCloseWindow;
        private Panel panel1;
        private RadioButton rdoNG1;
        private RadioButton rdoOK1;
        private Panel panel3;
        private RadioButton rdoNG3;
        private RadioButton rdoOK3;
        private Panel panel2;
        private RadioButton rdoNG2;
        private RadioButton rdoOK2;
    }
}