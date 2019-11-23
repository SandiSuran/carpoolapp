using System.Collections.Generic;
using System.Linq;
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
        private readonly IEmployeeService _emplService;
        private readonly IMapper _mapper;

        public TravelController (ILogger<TravelController> logger, ITravelService service, IMapper mapper, IEmployeeService emplService) {
            _logger = logger;
            _service = service;
            _mapper = mapper;
            _emplService = emplService;
        }

        [HttpGet]
        public async Task<IEnumerable<TravelResource>> GetAllAsync () {
            var travels = await _service.ListAsync ();
            return travels;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync ([FromBody] SaveTravelResource resource) {
            if (!ModelState.IsValid)
                return BadRequest (ModelState.GetErrorMessages ());

            var travel = _mapper.Map<SaveTravelResource, Travel> (resource);
            var travelResult = await _service.SaveAsync (travel);
            var toggleTravelEmpResult = await _emplService.ToggleTravelEmployees (resource.EmployeeIdList, travelResult.Travel.ID);
            
            if (!travelResult.Success)
                return BadRequest (travelResult.Message);

            if (!toggleTravelEmpResult.Success)
                return BadRequest (toggleTravelEmpResult.Message);

            var travelResource = _mapper.Map<Travel, TravelResource> (travelResult.Travel);
            return Ok (travelResource);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] SaveTravelResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var travel = _mapper.Map<SaveTravelResource, Travel>(resource);
            var travelResult = await _service.UpdateAsync(id, travel);

            if (!travelResult.Success)
                return BadRequest(travelResult.Message);

            var toggleTravelEmpResult = await _emplService.ToggleTravelEmployees (resource.EmployeeIdList, travelResult.Travel.ID);

            if (!toggleTravelEmpResult.Success)
                return BadRequest (toggleTravelEmpResult.Message);

            var travelResource = _mapper.Map<Travel, TravelResource>(travelResult.Travel);
            return Ok(travelResource);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var result = await _service.DeleteAsync(id);

            if (!result.Success)
                return BadRequest(result.Message);

            var travelResource = _mapper.Map<Travel, TravelResource>(result.Travel);
            return Ok(travelResource);
        }

    }
}