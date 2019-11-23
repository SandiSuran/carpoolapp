using AutoMapper;
using carpoolapp.BLL.Resources;
using carpoolapp.Models;

namespace carpoolapp.BLL.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<TravelResource,Travel>();
        }
    }
}