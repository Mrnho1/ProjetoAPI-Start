namespace ProdutosAPI.Models;

public class Item
{
    public int qtd_pedido {  get; set; }
    public float valor_item { get; set; }
    public int? pedidoIdFk { get; set; }
    public virtual Pedido Pedido { get; set; }
    public int? produtoIdFk { get; set; }
    public virtual Produto Produto { get; set; }

}
