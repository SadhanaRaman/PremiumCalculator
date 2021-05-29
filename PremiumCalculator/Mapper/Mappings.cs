using AutoMapper;
using PremiumCalculator.Models;
using PremiumCalculator.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PremiumCalculator.Mapper
{
    public class Mappings:Profile
    {
        public Mappings()
        {
            CreateMap<Occupations, OccupationDto>().ReverseMap();
        }
    }
}
