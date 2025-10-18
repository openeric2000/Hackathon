namespace temperature_conversion
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
            button_1 = new Button();
            button_2 = new Button();
            button_3 = new Button();
            button_6 = new Button();
            button_5 = new Button();
            button_4 = new Button();
            button_9 = new Button();
            button_8 = new Button();
            button_7 = new Button();
            button_0 = new Button();
            button_dot = new Button();
            textBox1 = new TextBox();
            button_convert = new Button();
            button_clear = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            label1 = new Label();
            button_minus = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button_1
            // 
            button_1.Location = new Point(343, 53);
            button_1.Name = "button_1";
            button_1.Size = new Size(60, 60);
            button_1.TabIndex = 1;
            button_1.Text = "1";
            button_1.UseVisualStyleBackColor = true;
            button_1.Click += button_1_Click;
            // 
            // button_2
            // 
            button_2.Location = new Point(434, 53);
            button_2.Name = "button_2";
            button_2.Size = new Size(60, 60);
            button_2.TabIndex = 2;
            button_2.Text = "2";
            button_2.UseVisualStyleBackColor = true;
            button_2.Click += button_2_Click;
            // 
            // button_3
            // 
            button_3.Location = new Point(525, 53);
            button_3.Name = "button_3";
            button_3.Size = new Size(60, 60);
            button_3.TabIndex = 3;
            button_3.Text = "3";
            button_3.UseVisualStyleBackColor = true;
            button_3.Click += button_3_Click;
            // 
            // button_6
            // 
            button_6.Location = new Point(525, 153);
            button_6.Name = "button_6";
            button_6.Size = new Size(60, 60);
            button_6.TabIndex = 6;
            button_6.Text = "6";
            button_6.UseVisualStyleBackColor = true;
            button_6.Click += button_6_Click;
            // 
            // button_5
            // 
            button_5.Location = new Point(434, 153);
            button_5.Name = "button_5";
            button_5.Size = new Size(60, 60);
            button_5.TabIndex = 5;
            button_5.Text = "5";
            button_5.UseVisualStyleBackColor = true;
            button_5.Click += button_5_Click;
            // 
            // button_4
            // 
            button_4.Location = new Point(343, 153);
            button_4.Name = "button_4";
            button_4.Size = new Size(60, 60);
            button_4.TabIndex = 4;
            button_4.Text = "4";
            button_4.UseVisualStyleBackColor = true;
            button_4.Click += button_4_Click;
            // 
            // button_9
            // 
            button_9.Location = new Point(525, 253);
            button_9.Name = "button_9";
            button_9.Size = new Size(60, 60);
            button_9.TabIndex = 9;
            button_9.Text = "9";
            button_9.UseVisualStyleBackColor = true;
            button_9.Click += button_9_Click;
            // 
            // button_8
            // 
            button_8.Location = new Point(434, 253);
            button_8.Name = "button_8";
            button_8.Size = new Size(60, 60);
            button_8.TabIndex = 8;
            button_8.Text = "8";
            button_8.UseVisualStyleBackColor = true;
            button_8.Click += button_8_Click;
            // 
            // button_7
            // 
            button_7.Location = new Point(343, 253);
            button_7.Name = "button_7";
            button_7.Size = new Size(60, 60);
            button_7.TabIndex = 7;
            button_7.Text = "7";
            button_7.UseVisualStyleBackColor = true;
            button_7.Click += button_7_Click;
            // 
            // button_0
            // 
            button_0.Location = new Point(343, 353);
            button_0.Name = "button_0";
            button_0.Size = new Size(60, 60);
            button_0.TabIndex = 11;
            button_0.Text = "0";
            button_0.UseVisualStyleBackColor = true;
            button_0.Click += button_0_Click;
            // 
            // button_dot
            // 
            button_dot.Location = new Point(434, 353);
            button_dot.Name = "button_dot";
            button_dot.Size = new Size(60, 60);
            button_dot.TabIndex = 10;
            button_dot.Text = ".";
            button_dot.UseVisualStyleBackColor = true;
            button_dot.Click += button_dot_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(652, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(291, 34);
            textBox1.TabIndex = 13;
            // 
            // button_convert
            // 
            button_convert.Location = new Point(652, 253);
            button_convert.Name = "button_convert";
            button_convert.Size = new Size(100, 50);
            button_convert.TabIndex = 14;
            button_convert.Text = "轉換";
            button_convert.UseVisualStyleBackColor = true;
            button_convert.Click += button_convert_Click;
            // 
            // button_clear
            // 
            button_clear.Location = new Point(789, 253);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(100, 50);
            button_clear.TabIndex = 15;
            button_clear.Text = "清除";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += button_clear_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(35, 25);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(159, 31);
            radioButton1.TabIndex = 17;
            radioButton1.TabStop = true;
            radioButton1.Text = "攝氏轉換為華氏";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(35, 96);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(159, 31);
            radioButton2.TabIndex = 18;
            radioButton2.TabStop = true;
            radioButton2.Text = "華氏轉換為攝氏";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(33, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 169);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Location = new Point(652, 353);
            label1.Name = "label1";
            label1.Size = new Size(237, 60);
            label1.TabIndex = 20;
            label1.UseWaitCursor = true;
            // 
            // button_minus
            // 
            button_minus.Location = new Point(525, 353);
            button_minus.Name = "button_minus";
            button_minus.Size = new Size(60, 60);
            button_minus.TabIndex = 21;
            button_minus.Text = "-";
            button_minus.UseVisualStyleBackColor = true;
            button_minus.Click += button_minus_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 550);
            Controls.Add(button_minus);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(button_clear);
            Controls.Add(button_convert);
            Controls.Add(textBox1);
            Controls.Add(button_0);
            Controls.Add(button_dot);
            Controls.Add(button_9);
            Controls.Add(button_8);
            Controls.Add(button_7);
            Controls.Add(button_6);
            Controls.Add(button_5);
            Controls.Add(button_4);
            Controls.Add(button_3);
            Controls.Add(button_2);
            Controls.Add(button_1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_1;
        private Button button_2;
        private Button button_3;
        private Button button_6;
        private Button button_5;
        private Button button_4;
        private Button button_9;
        private Button button_8;
        private Button button_7;
        private Button button_0;
        private Button button_dot;
        private TextBox textBox1;
        private Button button_convert;
        private Button button_clear;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
        private Label label1;
        private Button button_minus;
    }
}
