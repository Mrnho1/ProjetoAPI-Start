namespace ProdutosAPI.Data.DTOs;

public class CreateItemDto
{
    public int qtd_pedido { get; set; }
    public float valor_item { get; set; }
    public int? pedidoId { get; set; }
    public int? produtoId { get; set; }

}
