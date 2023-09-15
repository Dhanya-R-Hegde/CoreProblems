using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProblems
{
    internal class SwapNumbers
    {

        public int num1;
        public int num2;

        public SwapNumbers(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;

            Console.WriteLine("Before swapping : num1 = " + num1 + " num2 = " + num2);
        }
        public void swapNum()
        {
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine("After swapping : num1 = " + num1 + " num2 = " + num2);
        }
    }
}
