using carpoolapp.Models;

namespace carpoolapp.BLL.Services.Communication {
    public class TravelResponse : BaseResponse {
        public Travel _travel { get; private set; }
        public TravelResponse (bool success, string message, Travel travel) : base (success, message) {
            _travel = travel;
        }
        /// <summary>
        /// Creates a success response
        /// </summary>
        /// <param name="box">Saved, Updated or Deleted Travel</param>
        /// <returns>Response.</returns>
        public TravelResponse (Travel travel) : this (true, string.Empty, travel) { }

        /// <summary>
        /// Creates an error response
        /// </summary>
        /// <param name="message">Error message</param>
        /// <returns>Response.</returns>
        public TravelResponse (string message) : this (false, message, null) { }
    }
}