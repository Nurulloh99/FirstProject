namespace SRC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Son kiriting >> ");
            var number = Convert.ToInt32(Console.ReadLine());

            var ones = number % 10;
            var tens = number % 1000 % 100 / 10;
            var hundreds = number % 1000 / 100;
            var thousands = number / 1000;

            var summary = ones + tens + hundreds + thousands;
            Console.WriteLine($"Natija >> {summary}");
            Console.WriteLine();
            Main(args);
        }
    }
}
