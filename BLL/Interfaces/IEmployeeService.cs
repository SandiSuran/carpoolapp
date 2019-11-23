using System.Collections.Generic;
using System.Threading.Tasks;
using carpoolapp.BLL.Services.Communication;

namespace carpoolapp.BLL.Interfaces
{
    public interface IEmployeeService
    {
         Task<TravelEmployeesResponse> ToggleTravelEmployees(IEnumerable<int> employeeIds, int travelId);
    }
}