using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using carpoolapp.BLL.Interfaces;
using carpoolapp.BLL.Resources;
using Microsoft.AspNetCore.Mvc;

namespace carpoolapp.Controllers
{
    [ApiController]
    [Route ("[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;
        private readonly IMapper _mapper;
        public CarController(ICarService carService,  IMapper mapper)
        {
            _carService = carService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<CarResource>> GetAllAsync(){
            return await _carService.ListAsync();
        }
    }
}