using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1.Controllers
{
    /// <summary>
    /// This controller provides methods for generating a greeting message.
    /// </summary>
    public class GreetingController : ApiController
    {
        /// <summary>
        /// Generates a greeting message using a POST request.
        /// </summary>
        /// <returns>The greeting message "Hello World".</returns>
        /// <example>
        /// POST /api/Greeting
        /// Returns: "Hello World"
        /// </example>
        [HttpPost]
        public string Greeting()
        {
            // Generate the greeting message
            string message = "Hello World";
            return message;
        }
        /// <summary>
        /// Generates a greeting message using a GET request.
        /// </summary>
        /// <returns>The greeting message "Hello World".</returns>
        /// <example>
        /// GET /api/Greeting
        /// Returns: "Hello World"
        /// </example>
        [HttpGet]
        public string GetGreeting()
        {
            // Generate the greeting message
            string message = "Hello World";
            return message;
        }

    }
}

