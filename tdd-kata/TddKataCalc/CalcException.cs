namespace TddKataCalc;

public class CalcException : Exception
{
    public CalcException(string message, Exception exception) : base(message, exception)
    {
    }

    public CalcException(string message) : base(message)
    {
    }
}