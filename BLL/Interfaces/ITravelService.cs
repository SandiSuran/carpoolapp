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
         
         Task<TravelResponse> DeleteAsync(int travelId);
         Task<TravelResponse> UpdateAsync(int travelId, Travel travel);
         Task<TravelResponse> SaveAsync(Travel travel);
         Task<IEnumerable<TravelResource>> ListAsync();
         Task<IEnumerable<TravelResource>> ListTravelsForTimePeriod(string month);
    }
}