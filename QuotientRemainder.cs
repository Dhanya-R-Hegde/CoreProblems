using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProblems
{
    internal class QuotientRemainder
    {
        public int quotient;
        public int remainder;

        public void division(int num1, int num2)
        {
            quotient = num1 / num2;
            remainder = num1 % num2;

            Console.WriteLine("Quotient : " + quotient + "  Remainder : " + remainder);
        }
    }
}
