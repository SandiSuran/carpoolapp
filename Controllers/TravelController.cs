using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using carpoolapp.BLL.Interfaces;
using carpoolapp.BLL.Resources;
using carpoolapp.Extensions;
using carpoolapp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace carpoolapp.Controllers {
    [ApiController]
    [Route ("[controller]")]
    public class TravelController : ControllerBase {

        private readonly ILogger<TravelController> _logger;
        private readonly ITravelService _service;
        private readonly IMapper _mapper;

        public TravelController (ILogger<TravelController> logger, ITravelService service, IMapper mapper) {
            _logger = logger;
            _service = service;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IEnumerable<TravelResource>> GetAllAsync () {
            var travels = await _service.ListAsync ();
            return travels;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync ([FromBody] SaveTravelResource resource) { 
            if(!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var travel = _mapper.Map<SaveTravelResource, Travel>(resource);
            var result = await _service.SaveAsync(travel);

            if(!result.Success)
                return BadRequest(result.Message);

            var travelResource = _mapper.Map<Travel, TravelResource>(result.Travel);
            return Ok(travelResource);
        }
    }
}