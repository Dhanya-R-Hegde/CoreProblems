using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProblems
{
    internal class LargestAmongThree
    {
        public void largestNum(int num1, int num2, int num3)
        {
            if (num1 > num2 && num1 > num3) Console.WriteLine("Largest number is : " + num1);
            else if (num2 > num1 && num2 > num3) Console.WriteLine("Largest number is : " + num2);
            else if (num3 > num1 && num3 > num2) Console.WriteLine("Largest number is : " + num3);
        }
    }
}
