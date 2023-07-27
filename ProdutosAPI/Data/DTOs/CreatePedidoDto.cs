using ProdutosAPI.Models;

namespace ProdutosAPI.Data.DTOs;

public class CreatePedidoDto
{

    public DateOnly data_pedido { get; set; }

    public float valor_total { get; set; }

    public int clienteId { get; set; }

}
