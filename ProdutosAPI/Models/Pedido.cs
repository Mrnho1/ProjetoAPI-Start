using System.ComponentModel.DataAnnotations;

namespace ProdutosAPI.Models;

public class Pedido
{
    [Key]
    [Required]
    public int id { get; set; }

    public DateOnly data_pedido { get; set; }

    public float valor_total { get; set; }

    [Required]
    public int clienteId { get; set; }
    public virtual Cliente Cliente { get; set; }


}
