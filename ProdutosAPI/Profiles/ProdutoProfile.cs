using AutoMapper;
using ProdutosAPI.Data.DTOs;
using ProdutosAPI.Models;

namespace ProdutosAPI.Profiles;

public class ProdutoProfile:Profile
{
    public ProdutoProfile() 
    {
        //Esse create map converte o create produto dto em um produto para inserir no banco
        CreateMap<CreateProdutoDto, Produto>();
        CreateMap<UpdateProdutoDto, Produto>();
        CreateMap<Produto, CreateProdutoDto>();
        CreateMap<Produto, ReadProdutoDto>();

    }
}
