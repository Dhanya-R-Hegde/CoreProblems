using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProblems
{
    internal class PowerOfTwo
    {
        public int n;
        public PowerOfTwo(int n)
        {
            this.n = n;
        }

        public void powerOfTwo()
        {
            for (int i = 0; i <= n; i++)
            {
                Console.Write(Math.Pow(2, i) + "  ");
            }
        }
    }
}
