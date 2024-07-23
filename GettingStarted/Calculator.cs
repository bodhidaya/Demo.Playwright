using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted
{
    public class Calculator
    {
        public decimal Add(decimal num1, decimal num2)
        {
            var total = num1 + num2;
            return total;
        }

        public decimal Subtract(decimal num1, decimal num2)
        {
            var total = num1 - num2;
            return total;
        }

    }
}
