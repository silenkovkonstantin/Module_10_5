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
                double[] numbers = new double[2];

                Console.WriteLine("Введите два числа");

                for (int i = 0; i < 2; i++)
                {
                    string Str = Console.ReadLine();

                    if (Double.TryParse(Str, out numbers[i]))
                    {
                        numbers[i] = Double.Parse(Str);
                    }
                    else
                    {
                        throw new ArgumentException($"Введенное значение {Str} не является числом");
                    }
                }

                Logger = new Logger();
                Calculator calculator = new Calculator(Logger);
                double summ = ((IAddition)calculator).AddNumbers(numbers[0], numbers[1]);

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
