using TddKataCalc;

namespace TddKata
{
    /*
     * Create a simple String calculator with a method int Add(string numbers)
     * The method can take 0, 1 or 2 numbers, and will return their sum (for an empty string it will return 0)
     * for example "" or "1" or "1,2"
     * Start with the simplest test case of an empty string and move to 1 and 2 numbers
     * Remember to solve things as simply as possible so that you force yourself
     * * to write tests you did not think about
     * Remember to refactor after each passing test
    */

    public class UnitTest1
    {
        [Theory]
        [InlineData("")]
        [InlineData(",")]
        [InlineData("    ,    ")]
        public void Add_EmptyEntries_ReturnsZero(string emptyEntries)
        {
            var stringCalc = new Calc();
            var act = stringCalc.Add(emptyEntries);

            Assert.Equal(0,act);
        }

        [Fact]
        public void Add_NotADigit_Exception()
        {
            var stringCalc = new Calc();
            var notDigit = "someText";

            Assert.Throws<CalcException>(() => stringCalc.Add(notDigit));
        }

        [Fact]
        public void Add_HugeNumber_Exception()
        {
            var stringCalc = new Calc();
            var hugeNumber = $"{double.MaxValue:r}{double.MaxValue:r}";

            Assert.Throws<CalcException>(() => stringCalc.Add(hugeNumber));
        }

        [Fact]
        public void Add_ResultOverflow_Exception()
        {
            var stringCalc = new Calc();
            var hugeNumber = $"{int.MaxValue},{int.MaxValue}";

            Assert.Throws<CalcException>(() => stringCalc.Add(hugeNumber));
        }

        [Theory]
        [InlineData("0", 0)]
        [InlineData("5", 5)]
        [InlineData("15", 15)]
        public void Add_SingleNumber_ReturnsSameNumber(string digits, int expected)
        {
            var stringCalc = new Calc();
            var act = stringCalc.Add(digits);

            Assert.Equal(expected, act);
        }

        [Theory]
        [InlineData("0,6", 6)]
        [InlineData("5,4", 9)]
        [InlineData("15,-15", 0)]
        public void Add_TwoNumbers_ReturnsSum(string digits, int expected)
        {
            var stringCalc = new Calc();
            var act = stringCalc.Add(digits);

            Assert.Equal(expected, act);
        }
    }

   
}