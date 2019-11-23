using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using carpoolapp.BLL.Interfaces;
using carpoolapp.BLL.Resources;
using carpoolapp.BLL.Services.Communication;
using carpoolapp.Models;
using Microsoft.EntityFrameworkCore;

namespace carpoolapp.BLL.Services {
    public class TravelService : ITravelService {
        private readonly Context _db;
        private readonly IMapper _mapper;
        public TravelService (Context db, IMapper mapper) {
            _db = db;
            _mapper = mapper;
        }

        public Task<TravelResponse> Create (TravelResource travel) {
            throw new NotImplementedException ();
        }

        public Task<TravelResponse> Delete (int travelId) {
            throw new NotImplementedException ();
        }

        public Task<Travel> GetTravel (int id) {
            throw new NotImplementedException ();
        }

        public async Task<IEnumerable<TravelResource>> ListAsync () {
            var modelList = await _db.Travels.ToListAsync ();
            return _mapper.Map<IEnumerable<Travel>, IEnumerable<TravelResource>> (modelList);
        }

        public Task<IEnumerable<TravelResource>> ListTravelsForTimePeriod (string month) {
            throw new NotImplementedException ();
        }

        public async Task<TravelResponse> SaveAsync (Travel travel) {
            try {

                await _db.Travels.AddAsync (travel);
                await _db.SaveChangesAsync ();

                return new TravelResponse (travel);
            } catch (Exception ex) {
                //TODO: Add loging
                return new TravelResponse ($"An error occurred when saving the travel: {ex.Message}");
            }

        }
    }
}