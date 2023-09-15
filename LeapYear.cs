using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProblems
{
    internal class LeapYear
    {
        public void leapYear(int year)
        {
            if (year % 400 == 0) Console.WriteLine("The given year is a Leap year");
            else if (year % 100 == 0) Console.WriteLine("The given year is not a Leap year");
            else if (year % 4 == 0) Console.WriteLine("The given year is a Leap year");
            else Console.WriteLine("The given year is not a Leap year");

        }
    }
}
