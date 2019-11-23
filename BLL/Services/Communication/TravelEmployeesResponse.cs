using System.Collections.Generic;
using carpoolapp.Models;

namespace carpoolapp.BLL.Services.Communication
{
    public class TravelEmployeesResponse : BaseResponse
    {
        public TravelEmployeesResponse (bool success, string message) : base (success, message) { }
        /// <summary>
        /// Creates a success response
        /// </summary>
        /// <param name="box">Saved, Updated or Deleted TravelEmployees</param>
        /// <returns>Response.</returns>
        public TravelEmployeesResponse () : this (true, string.Empty) { }

        /// <summary>
        /// Creates an error response
        /// </summary>
        /// <param name="message">Error message</param>
        /// <returns>Response.</returns>
        public TravelEmployeesResponse (string message) : this (false, message) { }
    }
}