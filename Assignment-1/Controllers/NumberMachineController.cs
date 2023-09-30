using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1.Controllers
{
    /// <summary>
    /// This controller provides methods for performing various operations on an integer.
    /// </summary>
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// Calculates addition, subtraction, multiplication, and division of the provided integer by 10.
        /// </summary>
        /// <param name="id">The input integer value.</param>
        /// <returns>
        /// A string containing the results of addition, subtraction, multiplication, and division
        /// of the input integer by 10.
        /// </returns>
        /// <example>
        /// GET /api/NumberMachine/5
        /// Returns: "Addition with 10 gives: 15, Subtraction with 10 gives: -5, Multiplication with 10 gives: 50, Division by 10 gives: 0"
        /// </example>
        [HttpGet]
        public string Get(int id)
        {
            // Calculate addition, subtraction, multiplication, and division
            int addition = id + 10;
            int subtraction = id - 10;
            int multiply = id * 10;
            int divide = id / 10;
            // Generate the result message
            string result = $"Addition with 10 gives: {addition}, Subtraction with 10 gives: {subtraction}, Multiplication with 10 gives: {multiply}, Division by 10 gives: {divide}";
            return result;

        }
    }
}
