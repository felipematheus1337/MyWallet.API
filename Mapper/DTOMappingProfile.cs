using AutoMapper;
using MyWalletApi.Domain;
using MyWalletApi.DTOs;

namespace MyWalletApi.Mapper;

public class DTOMappingProfile : Profile
{

    public DTOMappingProfile() {
        CreateMap<Usuario, CreateUserDto>().ReverseMap();
        CreateMap<Transacao, CreateTransacaoDto>().ReverseMap();
        CreateMap<Transacao, TransacaoResponseDto>().ReverseMap();
        CreateMap<Carteira, CarteiraResponseDto>().ReverseMap();
    }  
}
