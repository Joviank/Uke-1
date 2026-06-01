using Xunit;
using Calculator;

namespace Calculator.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_TwoNumbers_ReturnsCorrectSum()
    {
        // Arrange: Sette opp testdata og objekter
        var calculator = new Calculator();

        // Act: Utfør handlingen du tester
        var result = calculator.Add(4, 5);

        // Assert: Sjekker om resultatet er riktig
        Assert.Equal(9, result);
    }
}
