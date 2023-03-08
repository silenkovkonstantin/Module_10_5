using System;

namespace Task2
{
    class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            try
            {
                string[] numbers = new string[2];

                Console.WriteLine("Введите два числа");

                for (int i = 0; i < 2; i++)
                {
                    numbers[i] = Console.ReadLine();
                }

                Logger = new Logger();
                Calculator calculator = new Calculator(Logger);
                double summ = ((IAddition)calculator).AddNumbers(numbers);

                string result = string.Format("{0:f4}", summ);
                Console.WriteLine($"Сумма равна: {result}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
