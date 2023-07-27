namespace ProdutosAPI.Data.DTOs;

public class UpdatePedidoDto
{
    public DateOnly data_pedido { get; set; }

    public float valor_total { get; set; }
}
