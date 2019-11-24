using System.Collections.Generic;
using System.Threading.Tasks;
using carpoolapp.BLL.Resources;

namespace carpoolapp.BLL.Interfaces
{
    public interface ICarService
    {
         Task<IEnumerable<CarResource>> ListAsync();
    }
}