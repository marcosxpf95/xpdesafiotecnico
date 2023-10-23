using AutoMapper;
using XPDesafioTecnico.DTOs;
using XPDesafioTecnico.Models.Models;

namespace XPDesafioTecnico.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ClienteCreationDto, Cliente>()
               .ForMember(dest => dest.EnderecoPrincipal, opt => opt.MapFrom(src => new Endereco
               {
                   Rua = src.Rua,
                   Cidade = src.Cidade,
                   Estado = src.Estado,
                   CEP = src.CEP
               }));

            CreateMap<Endereco, EnderecoDto>();
            CreateMap<Cliente, ClienteDetalhadoGetDto>();
            CreateMap<Cliente, ClienteGetDto>();
        }
    }
}
