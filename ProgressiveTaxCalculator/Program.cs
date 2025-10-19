using System;

namespace ProgressiveTaxCalculatorV3
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal income;
            while (true)
            {
                Console.Write("請輸入您的年收入（元）：");
                if (decimal.TryParse(Console.ReadLine(), out income) && income >= 0)
                {
                    break;
                }

                Console.WriteLine("輸入無效，請輸入非負數值。");
            }

            decimal tax;
            decimal marginalRate;
            CalculateTax(income, out tax, out marginalRate);

            Console.WriteLine("\n年收入：{0:N0} 元", income);
            Console.WriteLine("應納稅額：{0:N2} 元", tax);
            Console.WriteLine("適用稅率（邊際稅率）：{0:P0}", marginalRate);

            decimal averageRate = income == 0 ? 0 : tax / income;
            Console.WriteLine("實際稅率（平均稅率）：{0:P2}", averageRate);
        }

        static void CalculateTax(decimal income, out decimal tax, out decimal marginalRate)
        {
            decimal[] brackets = { 540000, 1210000, 2420000, 4530000, 10310000 };
            decimal[] rates = { 0.05m, 0.12m, 0.20m, 0.30m, 0.40m, 0.50m };
            decimal[] quickDeduction = { 0m, 37800m, 134600m, 376600m, 829600m, 1345100m };

            int level = Enumerable.Range(0, brackets.Length).FirstOrDefault(i => income <= brackets[i], brackets.Length);

            if (level >= rates.Length) level = rates.Length - 1;

            marginalRate = rates[level];
            tax = income * rates[level] - quickDeduction[level];
        }
    }
}
