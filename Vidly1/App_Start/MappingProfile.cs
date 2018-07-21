using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly1.Dtos;
using Vidly1.Models;

namespace Vidly1.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            /*this.CreateMap<Customer, CustomerDto>();
            this.CreateMap<CustomerDto, Customer>();

            this.CreateMap<Movie, Movie>();
            this.CreateMap<CustomerDto, Customer>();*/
            // Domain to Dto
            this.CreateMap<Customer, CustomerDto>();
            this.CreateMap<Movie, MovieDto>();
            this.CreateMap<MembershipType, MembershipTypeDto>();
            this.CreateMap<Genre, GenreDto>();


            // Dto to Domain
            this.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            this.CreateMap<MovieDto, Movie>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}