using System.ComponentModel.DataAnnotations;

namespace ProdutosAPI.Models;

public class Pedido
{
    [Key]
    [Required]
    public int pedidoId { get; set; }

    public DateOnly data_pedido { get; set; }

    public float valor_total { get; set; }

    [Required]
    public virtual Cliente Fk { get; set; }

    public virtual ICollection<Item> Item_Produtos { get; set; }


}
