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

        public async Task<TravelResponse> DeleteAsync (int travelId) {
            var existingTravel = await _db.Travels.FindAsync (travelId);

            if (existingTravel == null)
                return new TravelResponse ("Travel not found.");

            try {
                _db.Travels.Remove (existingTravel);
                await _db.SaveChangesAsync();

                return new TravelResponse (existingTravel);
            } catch (Exception ex) {
                // Do some logging stuff
                return new TravelResponse ($"An error occurred when deleting the travel: {ex.Message}");
            }
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

        public async Task<TravelResponse> UpdateAsync (int travelId, Travel travel) {
            var existingTravel = await _db.Travels.FindAsync (travelId);

            if (existingTravel == null)
                return new TravelResponse ("Travel not found.");

            _mapper.Map (existingTravel, travel);

            try {
                _db.Update (existingTravel);
                await _db.SaveChangesAsync ();

                return new TravelResponse (existingTravel);
            } catch (Exception ex) {
                // Do some logging stuff
                return new TravelResponse ($"An error occurred when updating the travel: {ex.Message}");
            }
        }
    }
}