using Calculator;

using NUnit.Framework;

namespace AT_Lab2;

public class MultiplicationTests {
    
    [Test]
    public void shouldMultiplyTwoNumbers() {
        const int expected = 2;
        var actual = Calculator.Calculator.Evaluate("1", "2", "*");
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void shouldNotMultiplyIfLessOrMoreThenTwoOperands() {
        Assert.Throws<InvalidOperandException>(() => Calculator.Calculator.Evaluate("1", "2 3", "*"));
    }

    [Test]
    public void shouldNotMultiplyNumbersIfThereIsNoOperator() {
        Assert.Throws<InvalidOperatorException>(() => Calculator.Calculator.Evaluate("1", "2", ""));
    }

    [Test]
    public void shouldNotMultiplyNumbersIfOperatorIsInvalid() {
        Assert.Throws<InvalidOperatorException>(() => Calculator.Calculator.Evaluate("1", "2", "a"));
    }

    [Test]
    public void shouldNotMultiplyNumbersIfThereIsAnInvalidOperand() {
        Assert.Throws<InvalidOperandException>(() => Calculator.Calculator.Evaluate("1", "a", "*"));
        Assert.Throws<InvalidOperandException>(() => Calculator.Calculator.Evaluate("b", "2", "*"));
    }

    [Test]
    public void shouldNotMultiplyNumbersIfThereIsAnInvalidOperandAndOperator() {
        Assert.Throws<InvalidOperatorException>(() => Calculator.Calculator.Evaluate("a", "b", "c"));
    }

    [Test]
    public void shouldWorkOnFloatNumbers() {
        var actual = Calculator.Calculator.Evaluate("1.5", "2.5", "*");
        const double expected = 3.75;

        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void shouldWorkOnNegativeNumbers() {
        var actual = Calculator.Calculator.Evaluate("-1", "-2", "*");
        const int expected = 2;
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void shouldWorkOnNegativeAndPositiveNumbers() {
        const int expected = -2;
        var actual = Calculator.Calculator.Evaluate("-1", "2", "*");
        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void shouldWorkOnNegativeAndPositiveNumbersWithFloats() {
        var actual = Calculator.Calculator.Evaluate("-1.5", "2.6", "*");
        const double expected = -3.9;
        Assert.AreEqual(expected, actual, 0.0001);
    }
    
}