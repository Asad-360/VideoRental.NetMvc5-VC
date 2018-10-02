using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using VidlyMovieRentalApp.Dtos;
using VidlyMovieRentalApp.Models;

namespace VidlyMovieRentalApp.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer , CustomerDto>();
            Mapper.CreateMap<CustomerDto , CustomerDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
        }

    }
}