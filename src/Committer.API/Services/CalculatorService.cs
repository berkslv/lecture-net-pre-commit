namespace Committer.API.Services;

/// <summary>
/// Implementation of the calculator service
/// </summary>
public class CalculatorService : ICalculatorService
{
    /// <inheritdoc />
    public double Add(double a, double b)
    {
        return a + b;
    }

    /// <inheritdoc />
    public double Subtract(double a, double b)
    {
        return a - b;
    }

    /// <inheritdoc />
    public double Multiply(double a, double b)
    {
        return a * b;
    }

    /// <inheritdoc />
    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero");
        }
        
        return a / b;
    }
}
