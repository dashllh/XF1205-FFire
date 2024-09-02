namespace XF1205_FFire
{
    partial class AboutDialog
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            btnCloseDialog = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 52);
            label1.Name = "label1";
            label1.Size = new Size(59, 17);
            label1.TabIndex = 0;
            label1.Text = "客户名称:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 18);
            label2.Name = "label2";
            label2.Size = new Size(59, 17);
            label2.TabIndex = 1;
            label2.Text = "软件名称:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(315, 17);
            label3.Name = "label3";
            label3.Size = new Size(59, 17);
            label3.TabIndex = 2;
            label3.Text = "版      本:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 124);
            label4.Name = "label4";
            label4.Size = new Size(59, 17);
            label4.TabIndex = 3;
            label4.Text = "技术支持:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(315, 124);
            label5.Name = "label5";
            label5.Size = new Size(59, 17);
            label5.TabIndex = 4;
            label5.Text = "联系电话:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 87);
            label6.Name = "label6";
            label6.Size = new Size(59, 17);
            label6.TabIndex = 5;
            label6.Text = "试验标准:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(100, 52);
            label7.Name = "label7";
            label7.Size = new Size(200, 17);
            label7.TabIndex = 6;
            label7.Text = "国家防火建筑材料质量检验检测中心";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(100, 18);
            label8.Name = "label8";
            label8.Size = new Size(146, 17);
            label8.TabIndex = 7;
            label8.Text = "灭火毯F类火灭火试验系统";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(100, 87);
            label9.Name = "label9";
            label9.Size = new Size(87, 17);
            label9.TabIndex = 8;
            label9.Text = "XF 1205-2014";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(386, 18);
            label10.Name = "label10";
            label10.Size = new Size(25, 17);
            label10.TabIndex = 9;
            label10.Text = "2.0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(100, 124);
            label11.Name = "label11";
            label11.Size = new Size(152, 17);
            label11.TabIndex = 10;
            label11.Text = "成都九驱创智科技有限公司";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(386, 124);
            label12.Name = "label12";
            label12.Size = new Size(85, 17);
            label12.TabIndex = 11;
            label12.Text = "19980772362";
            // 
            // btnCloseDialog
            // 
            btnCloseDialog.Location = new Point(209, 171);
            btnCloseDialog.Name = "btnCloseDialog";
            btnCloseDialog.Size = new Size(82, 33);
            btnCloseDialog.TabIndex = 12;
            btnCloseDialog.Text = "关闭";
            btnCloseDialog.UseVisualStyleBackColor = true;
            btnCloseDialog.Click += btnCloseDialog_Click;
            // 
            // AboutDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 216);
            Controls.Add(btnCloseDialog);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "关于系统";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button btnCloseDialog;
    }
}