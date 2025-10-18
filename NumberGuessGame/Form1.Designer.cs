namespace NumberGuessGame
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
            btnStart = new Button();
            btnShowAnswer = new Button();
            lstHistory = new ListBox();
            txtGuess = new TextBox();
            btnCheck = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(42, 41);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(95, 45);
            btnStart.TabIndex = 0;
            btnStart.Text = "開始遊戲";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnShowAnswer
            // 
            btnShowAnswer.Location = new Point(42, 161);
            btnShowAnswer.Name = "btnShowAnswer";
            btnShowAnswer.Size = new Size(95, 45);
            btnShowAnswer.TabIndex = 1;
            btnShowAnswer.Text = "看答案";
            btnShowAnswer.UseVisualStyleBackColor = true;
            btnShowAnswer.Click += btnShowAnswer_Click;
            // 
            // lstHistory
            // 
            lstHistory.FormattingEnabled = true;
            lstHistory.Location = new Point(443, 41);
            lstHistory.Name = "lstHistory";
            lstHistory.Size = new Size(266, 355);
            lstHistory.TabIndex = 2;
            // 
            // txtGuess
            // 
            txtGuess.Location = new Point(42, 285);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(239, 34);
            txtGuess.TabIndex = 3;
            txtGuess.TextChanged += txtGuess_TextChanged;
            txtGuess.KeyDown += txtGuess_KeyDown;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(42, 351);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(95, 45);
            btnCheck.TabIndex = 4;
            btnCheck.Text = "檢查答案";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(186, 351);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(95, 45);
            btnReset.TabIndex = 5;
            btnReset.Text = "放棄重來";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(btnCheck);
            Controls.Add(txtGuess);
            Controls.Add(lstHistory);
            Controls.Add(btnShowAnswer);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnShowAnswer;
        private ListBox lstHistory;
        private TextBox txtGuess;
        private Button btnCheck;
        private Button btnReset;
    }
}
