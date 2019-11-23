using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using carpoolapp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace carpoolapp.Controllers {
    [ApiController]
    [Route ("[controller]")]
    public class TravelController : ControllerBase {

        private readonly ILogger<TravelController> _logger;

        public TravelController (ILogger<TravelController> logger) {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Travel> Get () {
            var newTravel = new Travel { ID = 1, StartLocation = "Zagreb", EndLocation = "Pula" };
            var listOfTravels = new List<Travel> ();
            listOfTravels.Add (newTravel);
            return listOfTravels;
        }
    }
}