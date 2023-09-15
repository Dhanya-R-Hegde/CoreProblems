using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProblems
{
    internal class VowelOrConsonent
    {
        public void alphabet(char c)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U') Console.WriteLine("The given alphabet is a vowel");
            else Console.WriteLine("The given alphabet is a consonent");
        }
    }
}
