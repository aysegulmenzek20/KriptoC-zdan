using AutoMapper;
using KriptoCüzdan.model.Dto;
using KriptoCüzdan.model.Dto.ResponseDto;
using KriptoCüzdan.model.entity;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Runtime.InteropServices;

namespace KriptoCüzdan.MappingProfile
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<KriptoAddRepuestDto, Cryptio>();
            CreateMap<AlımAddRequestDto, Alım>();
            CreateMap<CategoryAddRequestDto, Category>();
            CreateMap<SatımAddRequestDto,Satım>();
            CreateMap<KriptoUpdateRequestDto, Cryptio>();
            CreateMap< Cryptio,KriptoResponseDto>();
        
        
        
        }
    }
}
