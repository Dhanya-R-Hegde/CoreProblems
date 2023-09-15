namespace CoreProblems
{
    class Program
    {
        static void Main(string[] args)
        {

            FlipCoin flipCoin = new FlipCoin();
            flipCoin.headTailPercentage(8);

            LeapYear leapYear = new LeapYear();
            leapYear.leapYear(2004);

            PowerOfTwo powerOfTwo = new PowerOfTwo(10);
            powerOfTwo.powerOfTwo();

            HarmonicNumber harmonicNumber = new HarmonicNumber();
            harmonicNumber.harmonicNum(149);

        }
    }
}
