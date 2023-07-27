namespace ProdutosAPI.Data.DTOs;

public class ReadPedidoDto
{
    public int id { get; set; }
    public DateOnly data_pedido { get; set; }
    public float valor_total { get; set; }

}
