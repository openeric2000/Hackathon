using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一段英文句子：");
            string input = Console.ReadLine();

            // 若使用者未輸入內容
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("請輸入有效的文字！");
                return;
            }

            // 將輸入轉成小寫並依空白分割
            var words = input
                .ToLower()
                .Split(new char[] { ' ', ',', '.', '?', '!', ';', ':', '"', '\'' },
                       StringSplitOptions.RemoveEmptyEntries);

            // 使用 Dictionary 統計每個單字出現次數
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (wordCount.ContainsKey(word))
                    wordCount[word]++;
                else
                    wordCount[word] = 1;
            }

            Console.WriteLine("\n--- 統計結果 ---");
            foreach (var pair in wordCount)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }

            Console.WriteLine("\n按任意鍵結束...");
            Console.ReadKey();
        }
    }
}
