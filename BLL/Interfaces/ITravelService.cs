using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using carpoolapp.BLL.Resources;
using carpoolapp.BLL.Services.Communication;

namespace carpoolapp.BLL.Interfaces
{
    public interface ITravelService
    {
         Task<TravelResource> Create(TravelResource travel);
         Task<TravelResource> Delete(int travelId);
         Task<TravelResource> Update(TravelResource travel);
         Task<TravelResource> GetTravel(int id);

         Task<IEnumerable<TravelResource>> ListTravelsForTimePeriod(string month);
         Task<IEnumerable<TravelResource>> ListAsync();
    }
}