using System;
using System.Linq;
using System.Windows.Forms;

namespace NumberGuessGame
{
    public partial class Form1 : Form
    {
        private string answer = "";
        private int attempts = 0;
        private bool gameActive = false;

        public Form1()
        {
            InitializeComponent();
        }

        // 🔹 開始遊戲
        private void btnStart_Click(object sender, EventArgs e)
        {
            answer = GenerateAnswer();
            attempts = 0;
            gameActive = true;
            lstHistory.Items.Clear();
            txtGuess.Clear();
            txtGuess.Focus();
            MessageBox.Show("🎯 遊戲開始！請輸入 4 位不重複的數字。");
        }

        // 🔹 顯示答案
        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            if (!gameActive)
            {
                MessageBox.Show("請先按「開始遊戲」！");
                return;
            }

            MessageBox.Show($"💡 電腦的答案是：{answer}");
        }

        // 🔹 檢查猜測結果
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (!gameActive)
            {
                MessageBox.Show("請先開始遊戲！");
                return;
            }

            string guess = txtGuess.Text.Trim();

            if (!IsValidGuess(guess))
            {
                MessageBox.Show("❌ 請輸入 4 位不重複的數字！");
                return;
            }

            attempts++;
            string result = GetABResult(guess, answer);
            lstHistory.Items.Add($"{guess} → {result}");

            if (result == "4A0B")
            {
                MessageBox.Show($"🎉 恭喜你猜對了！總共猜了 {attempts} 次！");
                gameActive = false;
            }

            txtGuess.Clear();
            txtGuess.Focus();
        }

        // 🔹 重新開始
        private void btnReset_Click(object sender, EventArgs e)
        {
            answer = "";
            attempts = 0;
            gameActive = false;
            txtGuess.Clear();
            lstHistory.Items.Clear();
            MessageBox.Show("🔁 已重置，請按「開始遊戲」重新開始！");
        }

        // 🔹 按 Enter 觸發檢查
        private void txtGuess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCheck.PerformClick();
                e.SuppressKeyPress = true; // 阻止系統「嗶」聲
            }
        }

        // =========================
        // 🔧 功能方法區
        // =========================

        // 產生隨機不重複 4 位數
        private string GenerateAnswer()
        {
            Random rnd = new Random();
            return string.Concat(Enumerable.Range(0, 10)
                                           .OrderBy(_ => rnd.Next())
                                           .Take(4));
        }

        // 檢查輸入格式
        private bool IsValidGuess(string guess)
        {
            return guess.Length == 4
                && guess.All(char.IsDigit)
                && guess.Distinct().Count() == 4;
        }

        // 比對結果回傳 "xAyB"
        private string GetABResult(string guess, string ans)
        {
            int A = 0, B = 0;

            for (int i = 0; i < guess.Length; i++)
            {
                if (guess[i] == ans[i])
                    A++;
                else if (ans.Contains(guess[i]))
                    B++;
            }

            return $"{A}A{B}B";
        }

        private void txtGuess_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
