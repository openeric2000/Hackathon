namespace substitute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個大於 90 的整數：");
            string input = Console.ReadLine();
            bool success = int.TryParse(input, out int max);

            if (!success || max <= 90)
            {
                Console.WriteLine("輸入錯誤！請輸入大於 90 的整數。");
                return;
            }

            Enumerable.Range(1, max)
                .Select(i =>
                    i % 3 == 0 && i % 5 == 0 ? "Dann" :
                    i % 3 == 0 ? "Build" :
                    i % 5 == 0 ? "School" :
                    i.ToString())
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
