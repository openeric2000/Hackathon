namespace LifePathNumberApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            dtpBirth = new DateTimePicker();
            btnAnalyze = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(37, 37);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(102, 27);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "請選擇生日";
            // 
            // dtpBirth
            // 
            dtpBirth.Location = new Point(37, 89);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(347, 34);
            dtpBirth.TabIndex = 1;
            // 
            // btnAnalyze
            // 
            btnAnalyze.Location = new Point(37, 191);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(153, 75);
            btnAnalyze.TabIndex = 2;
            btnAnalyze.Text = "分析結果";
            btnAnalyze.UseVisualStyleBackColor = true;
            btnAnalyze.Click += btnAnalyze_Click;
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Location = new Point(429, 36);
            lblResult.MaximumSize = new Size(400, 330);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(400, 330);
            lblResult.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 450);
            Controls.Add(lblResult);
            Controls.Add(btnAnalyze);
            Controls.Add(dtpBirth);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private DateTimePicker dtpBirth;
        private Button btnAnalyze;
        private Label lblResult;
    }
}
