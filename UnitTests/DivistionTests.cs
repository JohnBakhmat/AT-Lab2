using System;

using Calculator;

using NUnit.Framework;

namespace AT_Lab2;

public class DivistionTests {
    
    [Test]
    public void shouldDivideTwoNumbers() {
        const double expected = 0.5;
        var actual = Calculator.Calculator.Evaluate("1", "2", "/");
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void shouldNotDivideIfLessOrMoreThenTwoOperands() {
        Assert.Throws<InvalidOperandException>(() => Calculator.Calculator.Evaluate("1", "2 3", "/"));
    }

    [Test]
    public void shouldNotDivideNumbersIfThereIsNoOperator() {
        Assert.Throws<InvalidOperatorException>(() => Calculator.Calculator.Evaluate("1", "2", ""));
    }

    [Test]
    public void shouldNotDivideNumbersIfOperatorIsInvalid() {
        Assert.Throws<InvalidOperatorException>(() => Calculator.Calculator.Evaluate("1", "2", "a"));
    }

    [Test]
    public void shouldNotDivideNumbersIfThereIsAnInvalidOperand() {
        Assert.Throws<InvalidOperandException>(() => Calculator.Calculator.Evaluate("1", "a", "/"));
        Assert.Throws<InvalidOperandException>(() => Calculator.Calculator.Evaluate("b", "2", "/"));
    }

    [Test]
    public void shouldNotDivideNumbersIfThereIsAnInvalidOperandAndOperator() {
        Assert.Throws<InvalidOperatorException>(() => Calculator.Calculator.Evaluate("a", "b", "c"));
    }

    [Test]
    public void shouldWorkOnFloatNumbers() {
        var actual = Calculator.Calculator.Evaluate("1.5", "2.5", "/");
        const double expected = 0.6;

        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void shouldWorkOnNegativeNumbers() {
        var actual = Calculator.Calculator.Evaluate("-1", "-2", "/");
        const double expected = 0.5;
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void shouldWorkOnNegativeAndPositiveNumbers() {
        const double expected = -0.5;
        var actual = Calculator.Calculator.Evaluate("-1", "2", "/");
        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void shouldWorkOnNegativeAndPositiveNumbersWithFloats() {
        var actual = Calculator.Calculator.Evaluate("-1.5", "2.5", "/");
        const double expected = -0.6;
        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void shouldWorkOnZero() {
        var actual = Calculator.Calculator.Evaluate("0", "2", "/");
        const double expected = 0;
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void shouldNotDivideOnZero() {
        Assert.Throws<DivideByZeroException>(() => Calculator.Calculator.Evaluate("1", "0", "/"));
    }
}