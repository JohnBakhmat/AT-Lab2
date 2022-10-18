using Calculator;

using NUnit.Framework;

namespace AT_Lab2;

public class SubtructionTests {
    
    [Test]
    public void shouldSubtractTwoNumbers() {
        const int expected = -1;
        var actual = Calculator.Calculator.Evaluate("1", "2", "-");
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void shouldNotSubtractIfLessOrMoreThenTwoOperands() {
        Assert.Throws<InvalidOperandException>(() => Calculator.Calculator.Evaluate("1", "2 3", "-"));
    }

    [Test]
    public void shouldNotSubtractNumbersIfThereIsNoOperator() {
        Assert.Throws<InvalidOperatorException>(() => Calculator.Calculator.Evaluate("1", "2", ""));
    }

    [Test]
    public void shouldNotSubtractNumbersIfOperatorIsInvalid() {
        Assert.Throws<InvalidOperatorException>(() => Calculator.Calculator.Evaluate("1", "2", "a"));
    }

    [Test]
    public void shouldNotSubtractNumbersIfThereIsAnInvalidOperand() {
        Assert.Throws<InvalidOperandException>(() => Calculator.Calculator.Evaluate("1", "a", "+"));
        Assert.Throws<InvalidOperandException>(() => Calculator.Calculator.Evaluate("b", "2", "+"));
    }

    [Test]
    public void shouldNotSubtractNumbersIfThereIsAnInvalidOperandAndOperator() {
        Assert.Throws<InvalidOperatorException>(() => Calculator.Calculator.Evaluate("a", "b", "c"));
    }

    [Test]
    public void shouldWorkOnFloatNumbers() {
        const double expected = -0.9;
        var actual = Calculator.Calculator.Evaluate("1.5", "2.4", "-");
        Assert.AreEqual(expected, actual,0.0001);
    }
    
    [Test]
    public void shouldWorkOnNegativeNumbers() {
        const int expected = 1;
        var actual = Calculator.Calculator.Evaluate("-1", "-2", "-");
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void shouldWorkOnNegativeAndPositiveNumbers() {
        const int expected = -3;
        var actual = Calculator.Calculator.Evaluate("-1", "2", "-");
        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void shouldWorkOnNegativeAndPositiveNumbersWithFloats() {
        const double expected = -4.1;
        var actual = Calculator.Calculator.Evaluate("-1.5", "2.6", "-");
        Assert.AreEqual(expected, actual);
    }
    
}