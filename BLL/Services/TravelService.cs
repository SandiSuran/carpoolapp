using System;
using System.Threading.Tasks;
using AutoMapper;
using carpoolapp.BLL.Interfaces;
using carpoolapp.BLL.Resources;
using carpoolapp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace carpoolapp.BLL.Services
{
    public class TravelService : ITravelService
    {
        private readonly Context _db;
        private readonly IMapper _mapper;
        public TravelService(Context db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public Task<TravelResource> Create(TravelResource travel)
        {
            throw new NotImplementedException();
        }

        public Task<TravelResource> Delete(int travelId)
        {
            throw new NotImplementedException();
        }

        public Task<TravelResource> GetTravel(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TravelResource>> ListAsync()
        {
            var modelList = await _db.Travels.ToListAsync();
            return _mapper.Map<IEnumerable<Travel>, IEnumerable<TravelResource>>(modelList);
        }

        public Task<IEnumerable<TravelResource>> ListTravelsForTimePeriod(string month)
        {
            throw new NotImplementedException();
        }

        public Task<TravelResource> Update(TravelResource travel)
        {
            throw new NotImplementedException();
        }
    }
}