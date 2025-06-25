using Microsoft.AspNetCore.Mvc;
using Committer.API.Services;

namespace Committer.API.Controllers;

/// <summary>
/// Controller for calculator operations
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class CalculatorController : ControllerBase
{
    private readonly ICalculatorService _calculatorService;
    
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="calculatorService">Calculator service</param>
    public CalculatorController(ICalculatorService calculatorService)
    {
        _calculatorService = calculatorService;
    }
    
    /// <summary>
    /// Adds two numbers
    /// </summary>
    /// <param name="a">First number</param>
    /// <param name="b">Second number</param>
    /// <returns>Sum of the two numbers</returns>
    [HttpGet("add")]
    public ActionResult<double> Add([FromQuery] double a, [FromQuery] double b)
    {
        return Ok(_calculatorService.Add(a, b));
    }
    
    /// <summary>
    /// Subtracts second number from first number
    /// </summary>
    /// <param name="a">First number</param>
    /// <param name="b">Second number</param>
    /// <returns>Difference between the two numbers</returns>
    [HttpGet("subtract")]
    public ActionResult<double> Subtract([FromQuery] double a, [FromQuery] double b)
    {
        return Ok(_calculatorService.Subtract(a, b));
    }
    
    /// <summary>
    /// Multiplies two numbers
    /// </summary>
    /// <param name="a">First number</param>
    /// <param name="b">Second number</param>
    /// <returns>Product of the two numbers</returns>
    [HttpGet("multiply")]
    public ActionResult<double> Multiply([FromQuery] double a, [FromQuery] double b)
    {
        return Ok(_calculatorService.Multiply(a, b));
    }
    
    /// <summary>
    /// Divides first number by second number
    /// </summary>
    /// <param name="a">First number (dividend)</param>
    /// <param name="b">Second number (divisor)</param>
    /// <returns>Quotient of the division</returns>
    [HttpGet("divide")]
    public ActionResult<double> Divide([FromQuery] double a, [FromQuery] double b)
    {
        try
        {
            return Ok(_calculatorService.Divide(a, b));
        }
        catch (DivideByZeroException ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
