using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LifePathNumberApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            DateTime birthDate = dtpBirth.Value;

            int lifeNum = GetLifeNumber(birthDate);
            string zodiac = GetZodiac(birthDate);
            string comment = GetCommentFromFile(zodiac, lifeNum);

            lblResult.Text = $"關於你\n\n" +
                             $"你的星座是 {zodiac}\n" +
                             $"你的生命靈數是：{lifeNum}\n" +
                             $"{comment}";
        }

        // 計算生命靈數
        private int GetLifeNumber(DateTime date)
        {
            string digits = date.ToString("yyyyMMdd");
            int sum = digits.Sum(c => c - '0');

            // 不斷把數字拆開相加直到剩一位
            while (sum >= 10)
            {
                sum = sum.ToString().Sum(c => c - '0');
            }

            return sum;
        }

        // 根據生日回傳星座
        private string GetZodiac(DateTime date)
        {
            int month = date.Month;
            int day = date.Day;

            if ((month == 3 && day >= 21) || (month == 4 && day <= 19)) return "牡羊座";
            if ((month == 4 && day >= 20) || (month == 5 && day <= 20)) return "金牛座";
            if ((month == 5 && day >= 21) || (month == 6 && day <= 21)) return "雙子座";
            if ((month == 6 && day >= 22) || (month == 7 && day <= 22)) return "巨蟹座";
            if ((month == 7 && day >= 23) || (month == 8 && day <= 22)) return "獅子座";
            if ((month == 8 && day >= 23) || (month == 9 && day <= 22)) return "處女座";
            if ((month == 9 && day >= 23) || (month == 10 && day <= 23)) return "天秤座";
            if ((month == 10 && day >= 24) || (month == 11 && day <= 22)) return "天蠍座";
            if ((month == 11 && day >= 23) || (month == 12 && day <= 21)) return "射手座";
            if ((month == 12 && day >= 22) || (month == 1 && day <= 19)) return "摩羯座";
            if ((month == 1 && day >= 20) || (month == 2 && day <= 18)) return "水瓶座";
            return "雙魚座";
        }

        // 讀取檔案找出對應評語
        private string GetCommentFromFile(string zodiac, int lifeNum)
        {
            string filePath = "生命靈數.txt";
            if (!File.Exists(filePath))
                return $"⚠️ 找不到生命靈數說明檔案（預期路徑：{Path.GetFullPath(filePath)}）";

            string[] lines = File.ReadAllLines(filePath);
            bool inZodiac = false;
            string comment = "";

            string chiName = zodiac.Trim(); // 現在 zodiac 是中文星座名，例如「獅子座」

            foreach (string line in lines)
            {
                // 若該行包含該中文星座名（即使前面有英文也會命中）
                if (line.Contains(chiName))
                {
                    inZodiac = true;
                }
                else if (inZodiac && line.Contains($"生命靈數{lifeNum}"))
                {
                    comment = line.Trim();
                    break;
                }
                else if (inZodiac && line.StartsWith("【")) // 下一個星座標題出現 → 結束搜尋
                {
                    break;
                }
            }

            if (string.IsNullOrEmpty(comment))
                return $"找不到 {zodiac} 的生命靈數 {lifeNum} 說明。";

            return comment;
        }

    }
}
