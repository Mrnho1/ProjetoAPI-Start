using System.ComponentModel.DataAnnotations;

namespace ProdutosAPI.Data.DTOs;

public class ReadProdutoDto
{
    public int produtoId { get; set; }
    public string nome_produto { get; set; }
    public float valor_produto { get; set; }
    public string categoria { get; set; }
}
