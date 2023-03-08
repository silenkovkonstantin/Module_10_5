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

        double IAddition.AddNumbers(double a, double b)
        {
            Logger.Event("Калькулятор начал работу");
            double sum = a + b;
            Logger.Event("Калькулятор окончил работу");
            return sum;
        }
    }
}
