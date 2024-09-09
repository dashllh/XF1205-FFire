namespace XF1205_FFire
{
    partial class ProgressForm
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
            lblTip = new Label();
            SuspendLayout();
            // 
            // lblTip
            // 
            lblTip.AutoSize = true;
            lblTip.Location = new Point(98, 38);
            lblTip.Name = "lblTip";
            lblTip.Size = new Size(170, 17);
            lblTip.TabIndex = 0;
            lblTip.Text = "正在生成试验报表，请稍等......";
            // 
            // ProgressForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 94);
            Controls.Add(lblTip);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProgressForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProgressForm";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTip;
    }
}