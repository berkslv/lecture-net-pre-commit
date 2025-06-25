namespace Committer.API.Services;

/// <summary>
/// Interface for calculator operations
/// </summary>
public interface ICalculatorService
{
    /// <summary>
    /// Adds two numbers
    /// </summary>
    /// <param name="a">First number</param>
    /// <param name="b">Second number</param>
    /// <returns>Sum of the two numbers</returns>
    double Add(double a, double b);
    
    /// <summary>
    /// Subtracts second number from first number
    /// </summary>
    /// <param name="a">First number</param>
    /// <param name="b">Second number</param>
    /// <returns>Difference between the two numbers</returns>
    double Subtract(double a, double b);
    
    /// <summary>
    /// Multiplies two numbers
    /// </summary>
    /// <param name="a">First number</param>
    /// <param name="b">Second number</param>
    /// <returns>Product of the two numbers</returns>
    double Multiply(double a, double b);
    
    /// <summary>
    /// Divides first number by second number
    /// </summary>
    /// <param name="a">First number (dividend)</param>
    /// <param name="b">Second number (divisor)</param>
    /// <returns>Quotient of the division</returns>
    /// <exception cref="DivideByZeroException">Thrown when divisor is zero</exception>
    double Divide(double a, double b);
}
