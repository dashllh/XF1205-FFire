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
            btnConfirm = new Button();
            btnCancel = new Button();
            label1 = new Label();
            txtSampleId = new TextBox();
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
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.None;
            btnConfirm.Location = new Point(267, 556);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(82, 34);
            btnConfirm.TabIndex = 0;
            btnConfirm.Text = "确定";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.Location = new Point(355, 556);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 34);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "取消";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 62);
            label1.Name = "label1";
            label1.Size = new Size(59, 17);
            label1.TabIndex = 2;
            label1.Text = "样品编号:";
            // 
            // txtSampleId
            // 
            txtSampleId.Location = new Point(84, 59);
            txtSampleId.Name = "txtSampleId";
            txtSampleId.Size = new Size(108, 23);
            txtSampleId.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 62);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 4;
            label2.Text = "样品标识号:";
            // 
            // txtTestId
            // 
            txtTestId.Location = new Point(304, 59);
            txtTestId.Name = "txtTestId";
            txtTestId.Size = new Size(106, 23);
            txtTestId.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 25);
            label3.Name = "label3";
            label3.Size = new Size(59, 17);
            label3.TabIndex = 6;
            label3.Text = "产品名称:";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(84, 22);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(326, 23);
            txtProductName.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtLabHumidity);
            groupBox1.Controls.Add(txtLabTemp);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(425, 77);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "环境信息";
            // 
            // txtLabHumidity
            // 
            txtLabHumidity.Location = new Point(337, 32);
            txtLabHumidity.Name = "txtLabHumidity";
            txtLabHumidity.Size = new Size(73, 23);
            txtLabHumidity.TabIndex = 12;
            // 
            // txtLabTemp
            // 
            txtLabTemp.Location = new Point(118, 32);
            txtLabTemp.Name = "txtLabTemp";
            txtLabTemp.Size = new Size(74, 23);
            txtLabTemp.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(241, 35);
            label5.Name = "label5";
            label5.Size = new Size(90, 17);
            label5.TabIndex = 10;
            label5.Text = "实验室湿度(%):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 35);
            label4.Name = "label4";
            label4.Size = new Size(91, 17);
            label4.TabIndex = 9;
            label4.Text = "实验室温度(℃):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSamplePrepareTime);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtProductName);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtTestId);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtSampleId);
            groupBox2.Location = new Point(12, 95);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(425, 144);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "样品信息";
            // 
            // txtSamplePrepareTime
            // 
            txtSamplePrepareTime.Location = new Point(84, 96);
            txtSamplePrepareTime.Name = "txtSamplePrepareTime";
            txtSamplePrepareTime.Size = new Size(326, 23);
            txtSamplePrepareTime.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 99);
            label6.Name = "label6";
            label6.Size = new Size(59, 17);
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
            groupBox3.Location = new Point(12, 245);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(425, 116);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "试验信息";
            // 
            // txtOperator
            // 
            txtOperator.Location = new Point(292, 68);
            txtOperator.Name = "txtOperator";
            txtOperator.Size = new Size(118, 23);
            txtOperator.TabIndex = 14;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(227, 71);
            label13.Name = "label13";
            label13.Size = new Size(59, 17);
            label13.TabIndex = 13;
            label13.Text = "试验人员:";
            // 
            // txtTestDate
            // 
            txtTestDate.Location = new Point(292, 30);
            txtTestDate.Name = "txtTestDate";
            txtTestDate.Size = new Size(118, 23);
            txtTestDate.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(227, 33);
            label12.Name = "label12";
            label12.Size = new Size(59, 17);
            label12.TabIndex = 11;
            label12.Text = "试验日期:";
            // 
            // txtTestAccord
            // 
            txtTestAccord.Location = new Point(84, 67);
            txtTestAccord.Name = "txtTestAccord";
            txtTestAccord.Size = new Size(118, 23);
            txtTestAccord.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(19, 70);
            label11.Name = "label11";
            label11.Size = new Size(59, 17);
            label11.TabIndex = 9;
            label11.Text = "检验依据:";
            // 
            // txtRptId
            // 
            txtRptId.Location = new Point(84, 30);
            txtRptId.Name = "txtRptId";
            txtRptId.Size = new Size(118, 23);
            txtRptId.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 33);
            label10.Name = "label10";
            label10.Size = new Size(59, 17);
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
            groupBox4.Location = new Point(12, 367);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(425, 112);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "设备信息";
            // 
            // txtApparatusCheckDate
            // 
            txtApparatusCheckDate.Location = new Point(84, 66);
            txtApparatusCheckDate.Name = "txtApparatusCheckDate";
            txtApparatusCheckDate.Size = new Size(326, 23);
            txtApparatusCheckDate.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 69);
            label9.Name = "label9";
            label9.Size = new Size(59, 17);
            label9.TabIndex = 14;
            label9.Text = "检定日期:";
            // 
            // txtApparatusId
            // 
            txtApparatusId.Location = new Point(325, 30);
            txtApparatusId.Name = "txtApparatusId";
            txtApparatusId.Size = new Size(85, 23);
            txtApparatusId.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(260, 33);
            label8.Name = "label8";
            label8.Size = new Size(59, 17);
            label8.TabIndex = 12;
            label8.Text = "设备编号:";
            // 
            // txtApparatusName
            // 
            txtApparatusName.Location = new Point(84, 30);
            txtApparatusName.Name = "txtApparatusName";
            txtApparatusName.Size = new Size(170, 23);
            txtApparatusName.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 33);
            label7.Name = "label7";
            label7.Size = new Size(59, 17);
            label7.TabIndex = 10;
            label7.Text = "设备名称:";
            // 
            // btnClearInput
            // 
            btnClearInput.Anchor = AnchorStyles.None;
            btnClearInput.Location = new Point(12, 556);
            btnClearInput.Name = "btnClearInput";
            btnClearInput.Size = new Size(82, 34);
            btnClearInput.TabIndex = 12;
            btnClearInput.Text = "重置输入";
            btnClearInput.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBox1);
            groupBox5.Location = new Point(12, 485);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(425, 61);
            groupBox5.TabIndex = 13;
            groupBox5.TabStop = false;
            groupBox5.Text = "备注";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(389, 23);
            textBox1.TabIndex = 0;
            // 
            // NewTestDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 602);
            Controls.Add(groupBox5);
            Controls.Add(btnClearInput);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewTestDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "新建试验";
            TopMost = true;
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
        private TextBox textBox1;
    }
}