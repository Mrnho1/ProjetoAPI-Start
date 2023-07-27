using AutoMapper;
using ProdutosAPI.Data.DTOs;
using ProdutosAPI.Models;

namespace ProdutosAPI.Profiles;

public class ClienteProfile:Profile
{
    public ClienteProfile()
    {
        CreateMap<CreateClienteDto, Cliente>();
        CreateMap<Cliente, ReadClienteDto>();
        CreateMap<UpdateClienteDto, Cliente>();
    }
        
}
