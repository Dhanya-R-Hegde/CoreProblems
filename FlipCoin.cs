using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProblems
{
    internal class FlipCoin
    {
        public int head = 0;
        public int tail = 0;
        public float headPercentage;
        public float tailPercentage;

        private int randomNum()
        {
            Random random = new Random();
            int random_num = random.Next(0, 2);
            return random_num;
        }

        public void headTailPercentage(int num)
        {
            for (int i = 0; i < num; i++)
            {
                int headOrTail = randomNum();

                switch (headOrTail)
                {
                    case 0:
                        {
                            head++;
                            break;
                        }


                    case 1:
                        {
                            tail++;
                            break;
                        }
                }

            }
            headPercentage = (head * 100) / num;
            tailPercentage = (tail * 100) / num;

            Console.WriteLine("Percentage of head and tail for this perticular flip is, head = " + headPercentage + "%,  tail = " + tailPercentage + "%");
        }

    }
}
