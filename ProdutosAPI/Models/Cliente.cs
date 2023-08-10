using System.ComponentModel.DataAnnotations;

namespace ProdutosAPI.Models
{
    public class Cliente
    {
        [Key]
        [Required]
        public int clienteId{get; set;}

        public string nome_cliente { get; set;}

        public string endereco_cliente { get; set;}

        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
