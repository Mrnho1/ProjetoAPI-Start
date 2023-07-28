using AutoMapper;
using ProdutosAPI.Data.DTOs;
using ProdutosAPI.Models;

namespace ProdutosAPI.Profiles
{
    public class ItemProfile : Profile
    {
        public ItemProfile()
        {
            CreateMap<CreateItemDto, Item>();
            CreateMap<Item, ReadItemDto>();
        }
    }
}
