namespace XF1205_FFire
{
    partial class NewTestDialog
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
            btnConfirm = new Button();
            btnCancel = new Button();
            label1 = new Label();
            txtSampleId = new TextBox();
            dataModelBindingSource = new BindingSource(components);
            label2 = new Label();
            txtTestId = new TextBox();
            label3 = new Label();
            txtProductName = new TextBox();
            groupBox1 = new GroupBox();
            txtLabHumidity = new TextBox();
            txtLabTemp = new TextBox();
            label5 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            label15 = new Label();
            label14 = new Label();
            txtSamplePrepareTime = new TextBox();
            label6 = new Label();
            groupBox3 = new GroupBox();
            txtOperator = new TextBox();
            label13 = new Label();
            txtTestDate = new TextBox();
            label12 = new Label();
            txtTestAccord = new TextBox();
            label11 = new Label();
            txtRptId = new TextBox();
            label10 = new Label();
            groupBox4 = new GroupBox();
            txtApparatusCheckDate = new TextBox();
            label9 = new Label();
            txtApparatusId = new TextBox();
            label8 = new Label();
            txtApparatusName = new TextBox();
            label7 = new Label();
            btnClearInput = new Button();
            groupBox5 = new GroupBox();
            txtOtherTestAddress = new TextBox();
            rdoAddress2 = new RadioButton();
            rdoAddress1 = new RadioButton();
            txtTestMemo = new TextBox();
            dataModelBindingSource1 = new BindingSource(components);
            dataModelBindingSource2 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataModelBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataModelBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataModelBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.None;
            btnConfirm.Location = new Point(343, 707);
            btnConfirm.Margin = new Padding(4);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(105, 40);
            btnConfirm.TabIndex = 14;
            btnConfirm.Text = "确定";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.Location = new Point(456, 707);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 40);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "取消";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 73);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 2;
            label1.Text = "样品编号:";
            // 
            // txtSampleId
            // 
            txtSampleId.DataBindings.Add(new Binding("Text", dataModelBindingSource, "SampleId", true));
            txtSampleId.Location = new Point(108, 69);
            txtSampleId.Margin = new Padding(4);
            txtSampleId.Name = "txtSampleId";
            txtSampleId.Size = new Size(138, 27);
            txtSampleId.TabIndex = 3;
            txtSampleId.Leave += txtSampleId_Leave;
            // 
            // dataModelBindingSource
            // 
            dataModelBindingSource.DataSource = typeof(DataModel);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 73);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 4;
            label2.Text = "样品标识号:";
            // 
            // txtTestId
            // 
            txtTestId.DataBindings.Add(new Binding("Text", dataModelBindingSource, "TestId", true));
            txtTestId.Location = new Point(391, 69);
            txtTestId.Margin = new Padding(4);
            txtTestId.Name = "txtTestId";
            txtTestId.Size = new Size(135, 27);
            txtTestId.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 29);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 6;
            label3.Text = "产品名称:";
            // 
            // txtProductName
            // 
            txtProductName.DataBindings.Add(new Binding("Text", dataModelBindingSource, "ProductName", true));
            txtProductName.Location = new Point(108, 26);
            txtProductName.Margin = new Padding(4);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(418, 27);
            txtProductName.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtLabHumidity);
            groupBox1.Controls.Add(txtLabTemp);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(15, 14);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(546, 91);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "环境信息";
            // 
            // txtLabHumidity
            // 
            txtLabHumidity.DataBindings.Add(new Binding("Text", dataModelBindingSource, "Humidity", true));
            txtLabHumidity.Location = new Point(433, 38);
            txtLabHumidity.Margin = new Padding(4);
            txtLabHumidity.Name = "txtLabHumidity";
            txtLabHumidity.Size = new Size(93, 27);
            txtLabHumidity.TabIndex = 1;
            txtLabHumidity.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLabTemp
            // 
            txtLabTemp.DataBindings.Add(new Binding("Text", dataModelBindingSource, "LabTemperature", true));
            txtLabTemp.Location = new Point(152, 38);
            txtLabTemp.Margin = new Padding(4);
            txtLabTemp.Name = "txtLabTemp";
            txtLabTemp.Size = new Size(94, 27);
            txtLabTemp.TabIndex = 0;
            txtLabTemp.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(310, 41);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 10;
            label5.Text = "实验室湿度(%):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 41);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 9;
            label4.Text = "实验室温度(℃):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(txtSamplePrepareTime);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtProductName);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtTestId);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtSampleId);
            groupBox2.Location = new Point(15, 112);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(546, 169);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "样品信息";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.FlatStyle = FlatStyle.Flat;
            label15.ForeColor = Color.Red;
            label15.Location = new Point(9, 75);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(16, 20);
            label15.TabIndex = 10;
            label15.Text = "*";
            label15.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.FlatStyle = FlatStyle.Flat;
            label14.ForeColor = Color.Red;
            label14.Location = new Point(275, 75);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(16, 20);
            label14.TabIndex = 9;
            label14.Text = "*";
            label14.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSamplePrepareTime
            // 
            txtSamplePrepareTime.DataBindings.Add(new Binding("Text", dataModelBindingSource, "ProductPrepareTime", true));
            txtSamplePrepareTime.Location = new Point(108, 113);
            txtSamplePrepareTime.Margin = new Padding(4);
            txtSamplePrepareTime.Name = "txtSamplePrepareTime";
            txtSamplePrepareTime.Size = new Size(418, 27);
            txtSamplePrepareTime.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 116);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 8;
            label6.Text = "养护时间:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtOperator);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(txtTestDate);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(txtTestAccord);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txtRptId);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(15, 288);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(546, 136);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "试验信息";
            // 
            // txtOperator
            // 
            txtOperator.DataBindings.Add(new Binding("Text", dataModelBindingSource, "Operator", true));
            txtOperator.Location = new Point(375, 80);
            txtOperator.Margin = new Padding(4);
            txtOperator.Name = "txtOperator";
            txtOperator.Size = new Size(151, 27);
            txtOperator.TabIndex = 9;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(292, 84);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(73, 20);
            label13.TabIndex = 13;
            label13.Text = "试验人员:";
            // 
            // txtTestDate
            // 
            txtTestDate.DataBindings.Add(new Binding("Text", dataModelBindingSource, "TestDate", true));
            txtTestDate.Location = new Point(375, 35);
            txtTestDate.Margin = new Padding(4);
            txtTestDate.Name = "txtTestDate";
            txtTestDate.Size = new Size(151, 27);
            txtTestDate.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(292, 39);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(73, 20);
            label12.TabIndex = 11;
            label12.Text = "试验日期:";
            // 
            // txtTestAccord
            // 
            txtTestAccord.DataBindings.Add(new Binding("Text", dataModelBindingSource, "TestAccord", true));
            txtTestAccord.Location = new Point(108, 79);
            txtTestAccord.Margin = new Padding(4);
            txtTestAccord.Name = "txtTestAccord";
            txtTestAccord.Size = new Size(151, 27);
            txtTestAccord.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(24, 82);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(73, 20);
            label11.TabIndex = 9;
            label11.Text = "检验依据:";
            // 
            // txtRptId
            // 
            txtRptId.DataBindings.Add(new Binding("Text", dataModelBindingSource, "ReportId", true));
            txtRptId.Location = new Point(108, 35);
            txtRptId.Margin = new Padding(4);
            txtRptId.Name = "txtRptId";
            txtRptId.Size = new Size(151, 27);
            txtRptId.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 39);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(73, 20);
            label10.TabIndex = 7;
            label10.Text = "报告编号:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtApparatusCheckDate);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(txtApparatusId);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(txtApparatusName);
            groupBox4.Controls.Add(label7);
            groupBox4.Location = new Point(15, 432);
            groupBox4.Margin = new Padding(4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(546, 132);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "设备信息";
            // 
            // txtApparatusCheckDate
            // 
            txtApparatusCheckDate.DataBindings.Add(new Binding("Text", dataModelBindingSource, "ApparatusCheckDate", true));
            txtApparatusCheckDate.Location = new Point(108, 78);
            txtApparatusCheckDate.Margin = new Padding(4);
            txtApparatusCheckDate.Name = "txtApparatusCheckDate";
            txtApparatusCheckDate.Size = new Size(418, 27);
            txtApparatusCheckDate.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 81);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 14;
            label9.Text = "检定日期:";
            // 
            // txtApparatusId
            // 
            txtApparatusId.DataBindings.Add(new Binding("Text", dataModelBindingSource, "ApparatusId", true));
            txtApparatusId.Location = new Point(418, 35);
            txtApparatusId.Margin = new Padding(4);
            txtApparatusId.Name = "txtApparatusId";
            txtApparatusId.Size = new Size(108, 27);
            txtApparatusId.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(334, 39);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 12;
            label8.Text = "设备编号:";
            // 
            // txtApparatusName
            // 
            txtApparatusName.DataBindings.Add(new Binding("Text", dataModelBindingSource, "ApparatusName", true));
            txtApparatusName.Location = new Point(108, 35);
            txtApparatusName.Margin = new Padding(4);
            txtApparatusName.Name = "txtApparatusName";
            txtApparatusName.Size = new Size(217, 27);
            txtApparatusName.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 39);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 10;
            label7.Text = "设备名称:";
            // 
            // btnClearInput
            // 
            btnClearInput.Anchor = AnchorStyles.None;
            btnClearInput.Location = new Point(15, 707);
            btnClearInput.Margin = new Padding(4);
            btnClearInput.Name = "btnClearInput";
            btnClearInput.Size = new Size(105, 40);
            btnClearInput.TabIndex = 16;
            btnClearInput.Text = "重置输入";
            btnClearInput.UseVisualStyleBackColor = true;
            btnClearInput.Click += btnClearInput_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtOtherTestAddress);
            groupBox5.Controls.Add(rdoAddress2);
            groupBox5.Controls.Add(rdoAddress1);
            groupBox5.Controls.Add(txtTestMemo);
            groupBox5.Location = new Point(15, 571);
            groupBox5.Margin = new Padding(4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4);
            groupBox5.Size = new Size(546, 119);
            groupBox5.TabIndex = 13;
            groupBox5.TabStop = false;
            groupBox5.Text = "检验地点";
            // 
            // txtOtherTestAddress
            // 
            txtOtherTestAddress.Enabled = false;
            txtOtherTestAddress.Location = new Point(118, 69);
            txtOtherTestAddress.Name = "txtOtherTestAddress";
            txtOtherTestAddress.Size = new Size(408, 27);
            txtOtherTestAddress.TabIndex = 16;
            // 
            // rdoAddress2
            // 
            rdoAddress2.AutoSize = true;
            rdoAddress2.Location = new Point(39, 70);
            rdoAddress2.Name = "rdoAddress2";
            rdoAddress2.Size = new Size(68, 24);
            rdoAddress2.TabIndex = 15;
            rdoAddress2.Text = "其他 :";
            rdoAddress2.UseVisualStyleBackColor = true;
            rdoAddress2.CheckedChanged += rdoAddress2_CheckedChanged;
            // 
            // rdoAddress1
            // 
            rdoAddress1.AutoSize = true;
            rdoAddress1.Checked = true;
            rdoAddress1.Location = new Point(39, 33);
            rdoAddress1.Name = "rdoAddress1";
            rdoAddress1.Size = new Size(222, 24);
            rdoAddress1.TabIndex = 14;
            rdoAddress1.TabStop = true;
            rdoAddress1.Text = "四川省都江堰市学府路358号";
            rdoAddress1.UseVisualStyleBackColor = true;
            // 
            // txtTestMemo
            // 
            txtTestMemo.DataBindings.Add(new Binding("Text", dataModelBindingSource, "Memo", true));
            txtTestMemo.Location = new Point(470, 32);
            txtTestMemo.Margin = new Padding(4);
            txtTestMemo.Name = "txtTestMemo";
            txtTestMemo.Size = new Size(29, 27);
            txtTestMemo.TabIndex = 13;
            txtTestMemo.Visible = false;
            // 
            // dataModelBindingSource1
            // 
            dataModelBindingSource1.DataSource = typeof(DataModel);
            // 
            // dataModelBindingSource2
            // 
            dataModelBindingSource2.DataSource = typeof(DataModel);
            // 
            // NewTestDialog
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 765);
            Controls.Add(groupBox5);
            Controls.Add(btnClearInput);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewTestDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "新建试验";
            TopMost = true;
            Load += NewTestDialog_Load;
            ((System.ComponentModel.ISupportInitialize)dataModelBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataModelBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataModelBindingSource2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnConfirm;
        private Button btnCancel;
        private Label label1;
        private TextBox txtSampleId;
        private Label label2;
        private TextBox txtTestId;
        private Label label3;
        private TextBox txtProductName;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private TextBox txtLabHumidity;
        private TextBox txtLabTemp;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox txtSamplePrepareTime;
        private Label label6;
        private GroupBox groupBox4;
        private Label label9;
        private TextBox txtApparatusId;
        private Label label8;
        private TextBox txtApparatusName;
        private Label label7;
        private TextBox txtApparatusCheckDate;
        private TextBox txtOperator;
        private Label label13;
        private TextBox txtTestDate;
        private Label label12;
        private TextBox txtTestAccord;
        private Label label11;
        private TextBox txtRptId;
        private Label label10;
        private Button btnClearInput;
        private GroupBox groupBox5;
        private TextBox txtTestMemo;
        private BindingSource dataModelBindingSource;
        private BindingSource dataModelBindingSource1;
        private BindingSource dataModelBindingSource2;
        private Label label14;
        private Label label15;
        private TextBox txtOtherTestAddress;
        private RadioButton rdoAddress2;
        private RadioButton rdoAddress1;
    }
}