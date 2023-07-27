using AutoMapper;
using ProdutosAPI.Data.DTOs;
using ProdutosAPI.Models;

namespace ProdutosAPI.Profiles;

public class PedidoProfile : Profile
{
    public PedidoProfile()
    {
        CreateMap<CreatePedidoDto, Pedido>();
        CreateMap<Pedido, ReadPedidoDto>();
        CreateMap<UpdatePedidoDto, Pedido>();
    }
}
