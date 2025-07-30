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
            components = new System.ComponentModel.Container();
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
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            txtNGReason3 = new TextBox();
            txtNGReason2 = new TextBox();
            txtNGReason1 = new TextBox();
            btnStartTest = new Button();
            btnStopTest = new Button();
            chartOilTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnOpenValve = new Button();
            btnCloseValve = new Button();
            btnGenerateReport = new Button();
            btnCloseWindow = new Button();
            timer_counting = new System.Windows.Forms.Timer(components);
            groupBox3 = new GroupBox();
            lblHeatTime = new Label();
            label4 = new Label();
            groupBox4 = new GroupBox();
            lblOilTemperatureDelta = new Label();
            label2 = new Label();
            btnStartHeat = new Button();
            btnStopHeat = new Button();
            groupBox5 = new GroupBox();
            txtNGReasonFinalResult = new TextBox();
            rdoNGFinalResult = new RadioButton();
            rdoOKFinalResult = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox6.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartOilTemp).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTimer);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(31, 22);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(135, 88);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // lblTimer
            // 
            lblTimer.BackColor = Color.Black;
            lblTimer.Dock = DockStyle.Bottom;
            lblTimer.Font = new Font("Arial", 21.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblTimer.ForeColor = Color.Yellow;
            lblTimer.Location = new Point(4, 35);
            lblTimer.Margin = new Padding(4, 0, 4, 0);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(127, 49);
            lblTimer.TabIndex = 1;
            lblTimer.Text = "88888";
            lblTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "试验计时(s)";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblOilTemperature);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(31, 118);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(135, 88);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // lblOilTemperature
            // 
            lblOilTemperature.BackColor = Color.Black;
            lblOilTemperature.Dock = DockStyle.Bottom;
            lblOilTemperature.Font = new Font("Arial", 21.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblOilTemperature.ForeColor = Color.Yellow;
            lblOilTemperature.Location = new Point(4, 35);
            lblOilTemperature.Margin = new Padding(4, 0, 4, 0);
            lblOilTemperature.Name = "lblOilTemperature";
            lblOilTemperature.Size = new Size(127, 49);
            lblOilTemperature.TabIndex = 1;
            lblOilTemperature.Text = "88888";
            lblOilTemperature.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 14);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 0;
            label3.Text = "油面温度(℃)";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(panel3);
            groupBox6.Controls.Add(panel2);
            groupBox6.Controls.Add(panel1);
            groupBox6.Controls.Add(label16);
            groupBox6.Controls.Add(label15);
            groupBox6.Controls.Add(label14);
            groupBox6.Location = new Point(35, 467);
            groupBox6.Margin = new Padding(4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(4);
            groupBox6.Size = new Size(730, 160);
            groupBox6.TabIndex = 14;
            groupBox6.TabStop = false;
            groupBox6.Text = "试验记录";
            // 
            // panel3
            // 
            panel3.Controls.Add(rdoNG3);
            panel3.Controls.Add(rdoOK3);
            panel3.Location = new Point(484, 117);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(221, 38);
            panel3.TabIndex = 14;
            // 
            // rdoNG3
            // 
            rdoNG3.AutoSize = true;
            rdoNG3.Location = new Point(115, 7);
            rdoNG3.Margin = new Padding(4);
            rdoNG3.Name = "rdoNG3";
            rdoNG3.Size = new Size(105, 24);
            rdoNG3.TabIndex = 10;
            rdoNG3.Text = "不符合要求";
            rdoNG3.UseVisualStyleBackColor = true;
            rdoNG3.CheckedChanged += rdoNG3_CheckedChanged;
            // 
            // rdoOK3
            // 
            rdoOK3.AutoSize = true;
            rdoOK3.Location = new Point(12, 7);
            rdoOK3.Margin = new Padding(4);
            rdoOK3.Name = "rdoOK3";
            rdoOK3.Size = new Size(90, 24);
            rdoOK3.TabIndex = 9;
            rdoOK3.Text = "符合要求";
            rdoOK3.UseVisualStyleBackColor = true;
            rdoOK3.CheckedChanged += rdoOK3_CheckedChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(rdoNG2);
            panel2.Controls.Add(rdoOK2);
            panel2.Location = new Point(485, 78);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 32);
            panel2.TabIndex = 13;
            // 
            // rdoNG2
            // 
            rdoNG2.AutoSize = true;
            rdoNG2.Location = new Point(114, 4);
            rdoNG2.Margin = new Padding(4);
            rdoNG2.Name = "rdoNG2";
            rdoNG2.Size = new Size(105, 24);
            rdoNG2.TabIndex = 9;
            rdoNG2.Text = "不符合要求";
            rdoNG2.UseVisualStyleBackColor = true;
            rdoNG2.CheckedChanged += rdoNG2_CheckedChanged;
            // 
            // rdoOK2
            // 
            rdoOK2.AutoSize = true;
            rdoOK2.Location = new Point(10, 4);
            rdoOK2.Margin = new Padding(4);
            rdoOK2.Name = "rdoOK2";
            rdoOK2.Size = new Size(90, 24);
            rdoOK2.TabIndex = 8;
            rdoOK2.Text = "符合要求";
            rdoOK2.UseVisualStyleBackColor = true;
            rdoOK2.CheckedChanged += rdoOK2_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(rdoNG1);
            panel1.Controls.Add(rdoOK1);
            panel1.Location = new Point(485, 30);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 41);
            panel1.TabIndex = 12;
            // 
            // rdoNG1
            // 
            rdoNG1.AutoSize = true;
            rdoNG1.Location = new Point(113, 8);
            rdoNG1.Margin = new Padding(4);
            rdoNG1.Name = "rdoNG1";
            rdoNG1.Size = new Size(105, 24);
            rdoNG1.TabIndex = 8;
            rdoNG1.Text = "不符合要求";
            rdoNG1.UseVisualStyleBackColor = true;
            rdoNG1.CheckedChanged += rdoNG1_CheckedChanged;
            // 
            // rdoOK1
            // 
            rdoOK1.AutoSize = true;
            rdoOK1.Location = new Point(10, 8);
            rdoOK1.Margin = new Padding(4);
            rdoOK1.Name = "rdoOK1";
            rdoOK1.Size = new Size(90, 24);
            rdoOK1.TabIndex = 7;
            rdoOK1.Text = "符合要求";
            rdoOK1.UseVisualStyleBackColor = true;
            rdoOK1.CheckedChanged += rdoOK1_CheckedChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(27, 124);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(300, 20);
            label16.TabIndex = 2;
            label16.Text = "移开灭火毯后3min内油盘中残油不再自燃。";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(27, 82);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(309, 20);
            label15.TabIndex = 1;
            label15.Text = "移开灭火毯后看不到火焰且油盘中还有残油。";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(27, 39);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(453, 20);
            label14.TabIndex = 0;
            label14.Text = "灭火毯应能扑灭F类火; 在试验过程中, 灭火毯应保持完整不被烧穿。";
            // 
            // txtNGReason3
            // 
            txtNGReason3.Location = new Point(1124, 438);
            txtNGReason3.Margin = new Padding(4);
            txtNGReason3.Name = "txtNGReason3";
            txtNGReason3.Size = new Size(45, 27);
            txtNGReason3.TabIndex = 11;
            txtNGReason3.Visible = false;
            txtNGReason3.Leave += txtNGReason3_Leave;
            // 
            // txtNGReason2
            // 
            txtNGReason2.Location = new Point(1124, 396);
            txtNGReason2.Margin = new Padding(4);
            txtNGReason2.Name = "txtNGReason2";
            txtNGReason2.Size = new Size(45, 27);
            txtNGReason2.TabIndex = 10;
            txtNGReason2.Visible = false;
            txtNGReason2.Leave += txtNGReason2_Leave;
            // 
            // txtNGReason1
            // 
            txtNGReason1.Location = new Point(1124, 352);
            txtNGReason1.Margin = new Padding(4);
            txtNGReason1.Name = "txtNGReason1";
            txtNGReason1.Size = new Size(45, 27);
            txtNGReason1.TabIndex = 9;
            txtNGReason1.Visible = false;
            txtNGReason1.Leave += txtNGReason1_Leave;
            // 
            // btnStartTest
            // 
            btnStartTest.Location = new Point(31, 227);
            btnStartTest.Margin = new Padding(4);
            btnStartTest.Name = "btnStartTest";
            btnStartTest.Size = new Size(135, 40);
            btnStartTest.TabIndex = 15;
            btnStartTest.Text = "开始起火计时";
            btnStartTest.UseVisualStyleBackColor = true;
            btnStartTest.Click += btnStartTest_Click;
            // 
            // btnStopTest
            // 
            btnStopTest.Enabled = false;
            btnStopTest.Location = new Point(31, 286);
            btnStopTest.Margin = new Padding(4);
            btnStopTest.Name = "btnStopTest";
            btnStopTest.Size = new Size(135, 40);
            btnStopTest.TabIndex = 16;
            btnStopTest.Text = "停止起火计时";
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
            chartOilTemp.Location = new Point(192, 34);
            chartOilTemp.Margin = new Padding(4);
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
            chartOilTemp.Size = new Size(903, 409);
            chartOilTemp.TabIndex = 17;
            chartOilTemp.Text = "chart1";
            // 
            // btnOpenValve
            // 
            btnOpenValve.Location = new Point(31, 345);
            btnOpenValve.Margin = new Padding(4);
            btnOpenValve.Name = "btnOpenValve";
            btnOpenValve.Size = new Size(135, 40);
            btnOpenValve.TabIndex = 18;
            btnOpenValve.Text = "打开燃气阀";
            btnOpenValve.UseVisualStyleBackColor = true;
            btnOpenValve.Click += btnOpenValve_Click;
            // 
            // btnCloseValve
            // 
            btnCloseValve.Enabled = false;
            btnCloseValve.Location = new Point(31, 404);
            btnCloseValve.Margin = new Padding(4);
            btnCloseValve.Name = "btnCloseValve";
            btnCloseValve.Size = new Size(135, 40);
            btnCloseValve.TabIndex = 19;
            btnCloseValve.Text = "关闭燃气阀";
            btnCloseValve.UseVisualStyleBackColor = true;
            btnCloseValve.Click += btnCloseValve_Click;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Enabled = false;
            btnGenerateReport.Location = new Point(1121, 504);
            btnGenerateReport.Margin = new Padding(4);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(134, 49);
            btnGenerateReport.TabIndex = 20;
            btnGenerateReport.Text = "生成试验报告";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // btnCloseWindow
            // 
            btnCloseWindow.Location = new Point(1121, 567);
            btnCloseWindow.Margin = new Padding(4);
            btnCloseWindow.Name = "btnCloseWindow";
            btnCloseWindow.Size = new Size(134, 49);
            btnCloseWindow.TabIndex = 21;
            btnCloseWindow.Text = "关闭";
            btnCloseWindow.UseVisualStyleBackColor = true;
            btnCloseWindow.Click += btnCloseWindow_Click;
            // 
            // timer_counting
            // 
            timer_counting.Interval = 1000;
            timer_counting.Tick += timer_counting_Tick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblHeatTime);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(1116, 24);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(144, 86);
            groupBox3.TabIndex = 22;
            groupBox3.TabStop = false;
            // 
            // lblHeatTime
            // 
            lblHeatTime.BackColor = Color.Black;
            lblHeatTime.Dock = DockStyle.Bottom;
            lblHeatTime.Font = new Font("Arial", 21.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeatTime.ForeColor = Color.Yellow;
            lblHeatTime.Location = new Point(4, 35);
            lblHeatTime.Margin = new Padding(4, 0, 4, 0);
            lblHeatTime.Name = "lblHeatTime";
            lblHeatTime.Size = new Size(136, 47);
            lblHeatTime.TabIndex = 1;
            lblHeatTime.Text = "88888";
            lblHeatTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 13);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 0;
            label4.Text = "升温计时(s)";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblOilTemperatureDelta);
            groupBox4.Controls.Add(label2);
            groupBox4.Location = new Point(1116, 116);
            groupBox4.Margin = new Padding(4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(144, 86);
            groupBox4.TabIndex = 23;
            groupBox4.TabStop = false;
            // 
            // lblOilTemperatureDelta
            // 
            lblOilTemperatureDelta.BackColor = Color.Black;
            lblOilTemperatureDelta.Dock = DockStyle.Bottom;
            lblOilTemperatureDelta.Font = new Font("Arial", 21.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblOilTemperatureDelta.ForeColor = Color.Yellow;
            lblOilTemperatureDelta.Location = new Point(4, 35);
            lblOilTemperatureDelta.Margin = new Padding(4, 0, 4, 0);
            lblOilTemperatureDelta.Name = "lblOilTemperatureDelta";
            lblOilTemperatureDelta.Size = new Size(136, 47);
            lblOilTemperatureDelta.TabIndex = 1;
            lblOilTemperatureDelta.Text = "88888";
            lblOilTemperatureDelta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 13);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 0;
            label2.Text = "升温速率(℃/min)";
            // 
            // btnStartHeat
            // 
            btnStartHeat.Location = new Point(1121, 227);
            btnStartHeat.Margin = new Padding(4);
            btnStartHeat.Name = "btnStartHeat";
            btnStartHeat.Size = new Size(135, 40);
            btnStartHeat.TabIndex = 24;
            btnStartHeat.Text = "开始升温计时";
            btnStartHeat.UseVisualStyleBackColor = true;
            btnStartHeat.Click += btnStartHeat_Click;
            // 
            // btnStopHeat
            // 
            btnStopHeat.Enabled = false;
            btnStopHeat.Location = new Point(1121, 286);
            btnStopHeat.Margin = new Padding(4);
            btnStopHeat.Name = "btnStopHeat";
            btnStopHeat.Size = new Size(135, 40);
            btnStopHeat.TabIndex = 25;
            btnStopHeat.Text = "停止升温计时";
            btnStopHeat.UseVisualStyleBackColor = true;
            btnStopHeat.Click += btnStopHeat_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtNGReasonFinalResult);
            groupBox5.Controls.Add(rdoNGFinalResult);
            groupBox5.Controls.Add(rdoOKFinalResult);
            groupBox5.Location = new Point(789, 467);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(306, 160);
            groupBox5.TabIndex = 26;
            groupBox5.TabStop = false;
            groupBox5.Text = "试验结论";
            // 
            // txtNGReasonFinalResult
            // 
            txtNGReasonFinalResult.BorderStyle = BorderStyle.FixedSingle;
            txtNGReasonFinalResult.Enabled = false;
            txtNGReasonFinalResult.Location = new Point(28, 117);
            txtNGReasonFinalResult.Name = "txtNGReasonFinalResult";
            txtNGReasonFinalResult.Size = new Size(256, 27);
            txtNGReasonFinalResult.TabIndex = 2;
            txtNGReasonFinalResult.Leave += txtNGReasonFinalResult_Leave;
            // 
            // rdoNGFinalResult
            // 
            rdoNGFinalResult.AutoSize = true;
            rdoNGFinalResult.Location = new Point(28, 80);
            rdoNGFinalResult.Name = "rdoNGFinalResult";
            rdoNGFinalResult.Size = new Size(113, 24);
            rdoNGFinalResult.TabIndex = 1;
            rdoNGFinalResult.Text = "不符合要求 :";
            rdoNGFinalResult.UseVisualStyleBackColor = true;
            rdoNGFinalResult.CheckedChanged += rdoNGFinalResult_CheckedChanged;
            // 
            // rdoOKFinalResult
            // 
            rdoOKFinalResult.AutoSize = true;
            rdoOKFinalResult.Location = new Point(28, 37);
            rdoOKFinalResult.Name = "rdoOKFinalResult";
            rdoOKFinalResult.Size = new Size(90, 24);
            rdoOKFinalResult.TabIndex = 0;
            rdoOKFinalResult.Text = "符合要求";
            rdoOKFinalResult.UseVisualStyleBackColor = true;
            rdoOKFinalResult.CheckedChanged += rdoOKFinalResult_CheckedChanged;
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1287, 645);
            Controls.Add(groupBox5);
            Controls.Add(btnStopHeat);
            Controls.Add(btnStartHeat);
            Controls.Add(groupBox4);
            Controls.Add(txtNGReason3);
            Controls.Add(groupBox3);
            Controls.Add(txtNGReason2);
            Controls.Add(btnCloseWindow);
            Controls.Add(txtNGReason1);
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
            Margin = new Padding(4);
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
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Timer timer_counting;
        private GroupBox groupBox3;
        private Label lblHeatTime;
        private Label label4;
        private GroupBox groupBox4;
        private Label lblOilTemperatureDelta;
        private Label label2;
        private Button btnStartHeat;
        private Button btnStopHeat;
        private GroupBox groupBox5;
        private TextBox txtNGReasonFinalResult;
        private RadioButton rdoNGFinalResult;
        private RadioButton rdoOKFinalResult;
    }
}