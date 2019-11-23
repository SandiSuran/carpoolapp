using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using carpoolapp.BLL.Resources;
using carpoolapp.BLL.Services.Communication;
using carpoolapp.Models;

namespace carpoolapp.BLL.Interfaces
{
    public interface ITravelService
    {
         Task<TravelResponse> Create(TravelResource travel);
         Task<TravelResponse> Delete(int travelId);
         Task<TravelResponse> SaveAsync(Travel travel);
         Task<Travel> GetTravel(int id);

         Task<IEnumerable<TravelResource>> ListTravelsForTimePeriod(string month);
         Task<IEnumerable<TravelResource>> ListAsync();
    }
}