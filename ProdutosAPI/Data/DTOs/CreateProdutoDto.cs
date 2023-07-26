using System.ComponentModel.DataAnnotations;

namespace ProdutosAPI.Data.DTOs;

public class CreateProdutoDto
{
    
    [Required(ErrorMessage = "O nome do produto é essencialmente obrigatório!!")]
    [StringLength(50, ErrorMessage = "O nome do produto não deve exceder 50 caracteres")]
    public string nome_produto { get; set; }
    [Required(ErrorMessage = "O valor do produto é essencialmente obrigatório!!")]
    [Range(1, 500, ErrorMessage = "Nenhum produto deve exceder os R$500.00")]
    public float valor_produto { get; set; }

    public string categoria { get; set; }
}
