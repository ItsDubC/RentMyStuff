using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using RentMyStuff.Core.Dtos;
using RentMyStuff.Core.Models;

namespace RentMyStuff.Web
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Asset, AssetDto>();
            CreateMap<AssetType, AssetTypeDto>();

            CreateMap<AssetDto, Asset>().ForMember(x => x.Id, opt => opt.Ignore());
            CreateMap<AssetTypeDto, AssetType>().ForMember(x => x.Id, opt => opt.Ignore());
        }
    }
}
