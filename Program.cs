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

            QuotientRemainder quotientRemainder = new QuotientRemainder();
            quotientRemainder.division(57, 35);

            SwapNumbers swapNumbers = new SwapNumbers(5, 10);
            swapNumbers.swapNum();

            EvenOrOdd evenOrOdd = new EvenOrOdd();
            evenOrOdd.evenOrOdd(10);

            VowelOrConsonent vowelOrConsonent = new VowelOrConsonent();
            vowelOrConsonent.alphabet('A');

        }
    }
}
