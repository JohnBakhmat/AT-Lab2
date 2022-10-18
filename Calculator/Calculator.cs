using System.Text.RegularExpressions;

namespace Calculator;

public static class Calculator {
    private static readonly Dictionary<string, Func<double, double, double>> Operations = new() {
        {"+", (a, b) => a + b},
        {"-", (a, b) => a - b},
        {"*", (a, b) => a * b},
        {"/", (a, b) => a / b}
    };

    public static double Evaluate(string a, string b, string op) {
        if (!IsOperatorValid(op)) throw new InvalidOperatorException();

        if (!IsOperandValid(a) || !IsOperandValid(b)) throw new InvalidOperandException();

        var operandA = double.Parse(a);
        var operandB = double.Parse(b);

        if (operandB == 0 && op == "/") throw new DivideByZeroException();


        return Operations[op](operandA, operandB);
    }

    private static bool IsOperatorValid(string op) {
        return Operations.ContainsKey(op);
    }


    private static bool IsOperandValid(string operand) {
        return Regex.IsMatch(operand, @"^[0-9\.\-]+$");
    }
}
