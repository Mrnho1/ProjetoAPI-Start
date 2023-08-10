namespace ProdutosAPI.Data.DTOs;

public class UpdateItemDto
{
    public int qtd_pedido { get; set; }
    public float valor_item { get; set; }
    public int? pedidoIdFk { get; set; }
    public int? produtoIdFk { get; set; }
}
