using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1.Controllers
{
    /// <summary>
    /// This controller provides a method to generate a greeting message to a specified number of people.
    /// </summary>
    public class GreetingPeopleController : ApiController
    {
        /// <summary>
        /// Generates a greeting message to a specified number of people using a GET request.
        /// </summary>
        /// <param name="id">The number of people to greet.</param>
        /// <returns>The greeting message with the specified number of people.</returns>
        /// <example>
        /// GET /api/GreetingPeople/5
        /// Returns: "Greetings to 5 people!"
        /// </example>
        [HttpGet]
        public string Postgreeting(int id)
        {
            // Generate the greeting message
            string value = "Greetings to " + id + " people!";
            return value;
        }
    }

}
