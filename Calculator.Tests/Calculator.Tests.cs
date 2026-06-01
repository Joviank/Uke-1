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
    /* Arrange: Vi lager en kalkulator
       Act: Vi legger sammen 4 og 5
       Assert: Resultaet skal være 9
    */
    [Fact]
    public void Subtract_TwoNumbers_ReturnsCorrectSum()
    {
        // Arrange
        var calculator = new Calculator();
    
        // Act
        var result = calculator.Sub(8, 2);
    
        // Assert
        Assert.Equal(6, result);
    }

    [Fact]
    public void Multiply_TwoNumbers_ReturnsCorrectSum()
    {
        // Arrange
    
        // Act
    
        // Assert
    }

    [Fact]
    public void Divide_TwoNumbers_ReturnsCorrectSum()
    {
        // Arrange
    
        // Act
    
        // Assert
    }

    [Fact]
    public void Divide_ByZero_ThrowsException()
    {
        // Arrange

        // Act & Assert
    }
}
