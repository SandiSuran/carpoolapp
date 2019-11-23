using AutoMapper;
using carpoolapp.BLL.Resources;
using carpoolapp.Models;

namespace carpoolapp.BLL.Mapping
{
    public class ModelToResourceProfile : Profile
    {
         public ModelToResourceProfile()
        {
            CreateMap<Travel, TravelResource>();
        }
    }
}