using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using carpoolapp.BLL.Interfaces;
using carpoolapp.BLL.Resources;
using carpoolapp.Models;
using Microsoft.EntityFrameworkCore;

namespace carpoolapp.BLL.Services
{
    public class CarService : ICarService
    {
        private readonly Context _db;
        private readonly IMapper _mapper;
        public CarService (Context db, IMapper mapper) {
            _db = db;
            _mapper = mapper;
        }
        public async Task<IEnumerable<CarResource>> ListAsync()
        {
            var modelList = await _db.Cars.ToListAsync ();
            return _mapper.Map<IEnumerable<Car>, IEnumerable<CarResource>> (modelList);
        }
    }
}