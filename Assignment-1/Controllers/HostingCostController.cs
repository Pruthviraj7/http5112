using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1.Controllers
{
    /// <summary>
    /// This controller provides a method to calculate the hosting cost for a specified number of days.
    /// </summary
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// Calculates the hosting cost for a specified number of days.
        /// </summary>
        /// <param name="days">The number of days for which hosting cost is calculated.</param>
        /// <returns>
        /// A string containing the hosting cost details, including cost per fortnight, HST, and total cost.
        /// </returns>
        /// <example>
        /// GET /api/HostingCost/10
        /// Returns: "1 fortnight at $5.50/FN = $5.50 CAD
        ///          HST 13% = $0.72 CAD
        ///          Total = $6.22 CAD"
        /// </example>
        [HttpGet]
        [Route("api/HostingCost/{days}")]
        public string Get(int days)
        {
            // Define cost and tax rates
            double fortnightCost = 5.50; 
            double hstRate = 0.13;

            // Calculate full fortnights and remaining days
            int fullFortnights = (days / 14) + 1; 
            int remainingDays = days % 14;

            // Calculate the subtotal cost before tax
            double subtotal = (fullFortnights * fortnightCost) + (remainingDays * (fortnightCost / 14));

            // Calculate the HST amount
            double hstAmount = subtotal * hstRate;

            // Calculate the total cost including tax
            double totalCost = subtotal + hstAmount;

            // Generate cost details as strings
            string fortnightsText = fullFortnights == 1 ? "fortnight" : "fortnights";
            string costDetails1 = $"{fullFortnights} {fortnightsText} at ${fortnightCost:F2}/FN = ${subtotal:F2} CAD";
            string costDetails2 = $"HST {hstRate * 100}% = ${hstAmount:F2} CAD";
            string costDetails3 = $"Total = ${totalCost:F2} CAD";

            return $"{costDetails1}\n{costDetails2}\n{costDetails3}";
        }
    }
}
