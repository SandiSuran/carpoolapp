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
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _emplService;
        private readonly IMapper _mapper;
        public EmployeeController(IEmployeeService emplService,  IMapper mapper)
        {
            _emplService = emplService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<EmployeeResource>> GetAllAsync(){
            return await _emplService.ListAsync();
        }
    }
}