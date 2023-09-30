using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1.Controllers
{
    /// <summary>
    /// This controller provides a method to add 10 to an integer value.
    /// </summary>
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Adds 10 to the provided integer value.
        /// </summary>
        /// <param name="value">The input integer value to which 10 will be added.</param>
        /// <returns>The result of adding 10 to the input value.</returns>
        /// <example>
        /// GET /api/AddTen/5
        /// Returns: 15
        /// </example>
        
        [HttpGet]
        [Route("api/AddTen/{value}")]
        public int Get(int value)
        {   // Add 10 to the input value
            int result = value + 10;
            return (int)result;
        }
    }
}
