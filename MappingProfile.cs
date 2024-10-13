using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    using AutoMapper;

namespace automapper_practice
{

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Source, Destination>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.Name));
        }
    }

}
