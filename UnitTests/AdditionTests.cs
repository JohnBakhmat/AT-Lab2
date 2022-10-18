using NUnit.Framework;
using Calculator;

namespace AT_Lab2;

public class AdditionTests {

    [Test]
    public void shouldAddTwoNumbers() {
        const int expected = 3;
        var actual = Calculator.Calculator.Evaluate("1", "2", "+");
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void shouldNotAddIfLessOrMoreThenTwoOperands() {
        Assert.Throws<InvalidOperandException>(() => Calculator.Calculator.Evaluate("1", "2 3", "+"));
    }

    [Test]
    public void shouldNotAddNumbersIfThereIsNoOperator() {
        Assert.Throws<InvalidOperatorException>(() => Calculator.Calculator.Evaluate("1", "2", ""));
    }

    [Test]
    public void shouldNotAddNumbersIfOperatorIsInvalid() {
        Assert.Throws<InvalidOperatorException>(() => Calculator.Calculator.Evaluate("1", "2", "a"));
    }

    [Test]
    public void shouldNotAddNumbersIfThereIsAnInvalidOperand() {
        Assert.Throws<InvalidOperandException>(() => Calculator.Calculator.Evaluate("1", "a", "+"));
        Assert.Throws<InvalidOperandException>(() => Calculator.Calculator.Evaluate("b", "2", "+"));
    }

    [Test]
    public void shouldNotAddNumbersIfThereIsAnInvalidOperandAndOperator() {
        Assert.Throws<InvalidOperatorException>(() => Calculator.Calculator.Evaluate("a", "b", "c"));
    }

    [Test]
    public void shouldWorkOnFloatNumbers() {
        const double expected = 4.0;
        var actual = Calculator.Calculator.Evaluate("1.5", "2.5", "+");
        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void shouldWorkOnNegativeNumbers() {
        const int expected = -3;
        var actual = Calculator.Calculator.Evaluate("-1", "-2", "+");
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void shouldWorkOnNegativeAndPositiveNumbers() {
        const int expected = 1;
        var actual = Calculator.Calculator.Evaluate("-1", "2", "+");
        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void shouldWorkOnNegativeAndPositiveNumbersWithFloats() {
        const double expected = 1.1;
        var actual = Calculator.Calculator.Evaluate("-1.5", "2.6", "+");
        Assert.AreEqual(expected, actual);
    }
    
}