namespace Calculator;

public class InvalidOperandException : Exception
{
    public InvalidOperandException() : base( "Invalid input")
    {
        
    }
}