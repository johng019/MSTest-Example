using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest
{
    class CalculatorClass
    {
        public int quotient { get; set; }
        public int product { get; set; }
        public int diff { get; set; }
        public int sum { get; set; }
        private int num1 { get; set; }
        private int num2 { get; set; }

        public int Add(int num1, int num2) => sum = num1 + num2;
        public int Subtract(int num1, int num2) => diff = num1 - num2;
        public int Multiply(int num1, int num2) => product = num1 * num2;
        public int Divide(int num1, int num2) => quotient = num1 + num2;
    }
}
