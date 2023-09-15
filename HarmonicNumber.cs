using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProblems
{
    internal class HarmonicNumber
    {
        public void harmonicNum(int num)
        {
            double sum = 0;
            for (int i = 1; i <= num; i++)
            {
                sum += (double)1 / i;
            }
            Console.WriteLine("Nth harmonic number is " + sum);
        }
    }
}
