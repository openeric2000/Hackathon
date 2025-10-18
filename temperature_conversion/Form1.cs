using System;
using System.Windows.Forms;

namespace temperature_conversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 將按下的數字加入輸入框
        private void AppendNumber(string num)
        {
            textBox1.Text += num;
        }

        

        // RadioButton（可留空）
        private void radioButton1_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton2_CheckedChanged(object sender, EventArgs e) { }

        private void button13_Click_1(object sender, EventArgs e)
        {
            
        }

       
        private void button_1_Click(object sender, EventArgs e)
        {
            AppendNumber("1");
        }
        private void button_2_Click(object sender, EventArgs e)
        {
            AppendNumber("2");
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            AppendNumber("3");
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            AppendNumber("4");
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            AppendNumber("5");
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            AppendNumber("6");
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            AppendNumber("7");
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            AppendNumber("8");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            AppendNumber("9");
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            AppendNumber("0");
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            AppendNumber(".");
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "-";
            }
            else if (textBox1.Text.StartsWith("-"))
            {
                // 如果已經有負號，再按一次就移除
                textBox1.Text = textBox1.Text.Substring(1);
            }
            else
            {
                // 如果沒有負號，就加在最前面
                textBox1.Text = "-" + textBox1.Text;
            }
        }

        private void button_convert_Click(object sender, EventArgs e)
        {
            // 「轉換」按鈕
        
            if (!double.TryParse(textBox1.Text, out double value))
            {
                MessageBox.Show("請輸入正確的數值！");
                return;
            }

            double result = 0;
            string message = "";

            if (radioButton1.Checked) // 攝氏轉華氏
            {
                result = (9.0 / 5.0) * value + 32;
                message = $"結果：{value}℃ = {result:F1}℉";
            }
            else if (radioButton2.Checked) // 華氏轉攝氏
            {
                result = (value - 32) * 5.0 / 9.0;
                message = $"結果：{value}℉ = {result:F1}℃";
            }
            else
            {
                MessageBox.Show("請先選擇轉換方向！");
                return;
            }

            label1.Text = message;
        
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "結果：";
        }
    }
}
