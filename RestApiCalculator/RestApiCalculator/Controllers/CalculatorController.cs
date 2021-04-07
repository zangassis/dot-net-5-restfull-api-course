using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace RestApiBookRegister.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {

        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Get(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = this.ConvertToDecimal(firstNumber) + this.ConvertToDecimal(secondNumber);

                return Ok(sum.ToString());
            }

            return BadRequest("Inválid input");
        }

        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public IActionResult Subtraction(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var subtraction = this.ConvertToDecimal(firstNumber) - this.ConvertToDecimal(secondNumber);

                return Ok(subtraction.ToString());
            }

            return BadRequest("Inválid input");
        }

        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public IActionResult Division(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var division = this.ConvertToDecimal(firstNumber) / this.ConvertToDecimal(secondNumber);

                return Ok(division.ToString());
            }

            return BadRequest("Inválid input");
        }

        [HttpGet("multiplication/{firstNumber}/{secondNumber}")]
        public IActionResult Multiplication(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var multiplication = this.ConvertToDecimal(firstNumber) * this.ConvertToDecimal(secondNumber);

                return Ok(multiplication.ToString());
            }

            return BadRequest("Inválid input");
        }

        [HttpGet("mean/{firstNumber}/{secondNumber}")]
        public IActionResult Mean(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var mean = (this.ConvertToDecimal(firstNumber) + this.ConvertToDecimal(secondNumber)) / 2;

                return Ok(mean.ToString());
            }

            return BadRequest("Inválid input");
        }

        [HttpGet("square-root/{firstNumber}")]
        public IActionResult SquareRoot(string firstNumber)
        {
            if (IsNumeric(firstNumber))
            {
                var squareRoot = Math.Sqrt((double)this.ConvertToDecimal(firstNumber));

                return Ok(squareRoot.ToString());
            }

            return BadRequest("Inválid input");
        }

        private bool IsNumeric(string sNumber)
        {
            double number;

            bool isNumber = double.TryParse(sNumber
                , System.Globalization.NumberStyles.Any
                , System.Globalization.NumberFormatInfo.InvariantInfo
                , out number);

            return isNumber;
        }

        private decimal ConvertToDecimal(string sNumber)
        {
            decimal decimalValue;

            if (decimal.TryParse(sNumber, out decimalValue))
            {
                return decimalValue;
            }

            return 0;
        }
    }
}
