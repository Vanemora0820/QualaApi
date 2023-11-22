using ApiQuala.Dtos;
using AutoMapper;
using DB;

namespace ApiQuala.Mappers
{
    public class AutoMapping : Profile
    {
        public AutoMapping() {

            CreateMap<CreateBranchDto, Branch>();
            CreateMap<UpdateBranchDto, Branch>();
            CreateMap<CreateCoinDto, Coin>();
            CreateMap<UpdateCoinDto, Coin>();
        }


    }
}
