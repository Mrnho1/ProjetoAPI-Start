namespace ProdutosAPI.Data.DTOs;

public class ReadPedidoDto
{
    public int pedidoId { get; set; }
    public DateOnly data_pedido { get; set; }
    public float valor_total { get; set; }

}
