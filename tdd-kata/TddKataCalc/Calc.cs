namespace TddKataCalc
{
    public class Calc
    {
        public int Add(string digits = default)
        {
            var digitParts = digits.Split(",");
            if (digitParts.Length > 2)
            {
                throw new CalcException("Only 2 arguments is supported");
            }

            var firstNumber = 0;
            var firstArg = digitParts[0];
            if (!string.IsNullOrWhiteSpace(firstArg) && !int.TryParse(digitParts[0], out firstNumber))
            {
                throw new CalcException($"Not a number {digitParts[0]}");
            }

            var secondNumber = 0;
            if (digitParts.Length > 1)
            {
                var secondArg = digitParts[1];

                if (!string.IsNullOrWhiteSpace(secondArg) && !int.TryParse(secondArg, out secondNumber))
                {
                    throw new CalcException($"Not a number {secondArg}");
                }
            }

            try
            {
                return firstNumber + secondNumber;
            }
            catch (Exception e)
            {
                throw new CalcException($"Fail to add numbers {firstNumber} and {secondNumber}", e);
            }
        }
    }
}