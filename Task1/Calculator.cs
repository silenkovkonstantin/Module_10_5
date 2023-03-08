using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Calculator : IAddition
    {
        double IAddition.AddNumbers(double a, double b)
        {
            return a + b;
        }
    }
}
