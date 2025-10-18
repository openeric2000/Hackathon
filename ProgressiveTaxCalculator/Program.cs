using System;

namespace ProgressiveTaxCalculatorV3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入您的年收入（元）：");
            decimal income = decimal.Parse(Console.ReadLine());

            decimal tax;
            decimal marginalRate;
            CalculateTax(income, out tax, out marginalRate);

            Console.WriteLine($"\n年收入：{income:N0} 元");
            Console.WriteLine($"應納稅額：{tax:N2} 元");
            Console.WriteLine($"適用稅率（邊際稅率）：{marginalRate:P0}");
            Console.WriteLine($"實際稅率（平均稅率）：{(tax / income):P2}");
        }

        static void CalculateTax(decimal income, out decimal tax, out decimal marginalRate)
        {
            decimal[] brackets = { 540000, 1210000, 2420000, 4530000, 10310000 };
            decimal[] rates = { 0.05m, 0.12m, 0.20m, 0.30m, 0.40m, 0.50m };
            decimal[] quickDeduction = { 0m, 37800m, 134600m, 376600m, 829600m, 1345100m };

            int level;
            if (income <= brackets[0]) level = 0;
            else if (income <= brackets[1]) level = 1;
            else if (income <= brackets[2]) level = 2;
            else if (income <= brackets[3]) level = 3;
            else if (income <= brackets[4]) level = 4;
            else level = 5;

            marginalRate = rates[level];
            tax = income * rates[level] - quickDeduction[level];
        }
    }
}
