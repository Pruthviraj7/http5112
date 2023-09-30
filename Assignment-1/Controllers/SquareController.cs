using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1.Controllers
{   /// <summary>
    /// This controller provides a method to calculate the square of an integer value.
    /// </summary>
    public class SquareController : ApiController
    {
        /// <summary>
        /// Calculates the square of the provided integer value.
        /// </summary>
        /// <param name="value">The input integer value to be squared.</param>
        /// <returns>The square of the input value.</returns>
        /// <example>
        /// GET /api/Square/5
        /// Returns: 25
        /// </example>
        [HttpGet]
        [Route("api/Square/{value}")]
        public int Get(int value)
        {
            // Calculate the square of the input value
            
            int result = value * value;
            return (int)result;
        }
    }
}
