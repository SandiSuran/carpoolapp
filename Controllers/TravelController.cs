
using System.Collections.Generic;
using System.Threading.Tasks;
using carpoolapp.BLL.Interfaces;
using carpoolapp.BLL.Resources;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace carpoolapp.Controllers {
    [ApiController]
    [Route ("[controller]")]
    public class TravelController : ControllerBase {

        private readonly ILogger<TravelController> _logger;
        private readonly ITravelService _service;

        public TravelController (ILogger<TravelController> logger, ITravelService service) {
            _logger = logger;
            _service = service;
        }

        public async Task<IEnumerable<TravelResource>> GetAllAsync () {
            var travels = await _service.ListAsync();
            return travels;
        }
    }
}