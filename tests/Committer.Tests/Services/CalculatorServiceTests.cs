using Committer.API.Services;

namespace Committer.Tests.Services;

public class CalculatorServiceTests
{
    private readonly CalculatorService _sut;

    public CalculatorServiceTests()
    {
        _sut = new CalculatorService();
    }

    [Theory]
    [InlineData(5, 3, 8)]
    [InlineData(0, 0, 0)]
    [InlineData(-5, -3, -8)]
    [InlineData(5.5, 3.5, 9)]
    public void Add_ShouldReturnCorrectSum(double a, double b, double expected)
    {
        // Act
        var result = _sut.Add(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(5, 3, 2)]
    [InlineData(0, 0, 0)]
    [InlineData(-5, -3, -2)]
    [InlineData(5.5, 3.5, 2)]
    public void Subtract_ShouldReturnCorrectDifference(double a, double b, double expected)
    {
        // Act
        var result = _sut.Subtract(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(5, 3, 15)]
    [InlineData(0, 0, 0)]
    [InlineData(-5, -3, 15)]
    [InlineData(-5, 3, -15)]
    [InlineData(5.5, 2, 11)]
    public void Multiply_ShouldReturnCorrectProduct(double a, double b, double expected)
    {
        // Act
        var result = _sut.Multiply(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(6, 3, 2)]
    [InlineData(0, 1, 0)]
    [InlineData(-6, -3, 2)]
    [InlineData(-6, 3, -2)]
    [InlineData(5.5, 2.5, 2.2)]
    public void Divide_ShouldReturnCorrectQuotient(double a, double b, double expected)
    {
        // Act
        var result = _sut.Divide(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Divide_WhenDivisorIsZero_ShouldThrowDivideByZeroException()
    {
        // Arrange
        double a = 10;
        double b = 0;

        // Act & Assert
        var exception = Assert.Throws<DivideByZeroException>(() => _sut.Divide(a, b));
        Assert.Equal("Cannot divide by zero", exception.Message);
    }
}
