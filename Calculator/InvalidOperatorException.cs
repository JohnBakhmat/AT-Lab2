namespace Calculator;

public class InvalidOperatorException : Exception
{
    public InvalidOperatorException() : base( "Invalid operator")
    {
        
    }
}