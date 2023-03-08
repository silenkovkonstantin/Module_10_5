using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Calculator : IAddition
    {
        ILogger Logger { get; }
        public Calculator(ILogger logger)
        {
            Logger = logger;
        }

        double IAddition.AddNumbers(string[] numbers)
        {
            double[] doubleNumbers = new double[2];

            for (int i = 0; i < 2; i++)
            {
                if (Double.TryParse(numbers[i], out doubleNumbers[i]))
                {
                    doubleNumbers[i] = Double.Parse(numbers[i]);
                }
                else
                {
                    Logger.Error("Калькулятор прервал свою работу из-за ошибки");
                    throw new ArgumentException($"Введенное значение {numbers[i]} не является числом");
                }
            }

            Logger.Event("Калькулятор начал работу");
            double sum = doubleNumbers[0] + doubleNumbers[1];
            Logger.Event("Калькулятор окончил работу");
            return sum;
        }
    }
}
