using System.ComponentModel.DataAnnotations;

namespace ProdutosAPI.Models
{
    public class Cliente
    {
        [Key]
        [Required]
        public int id{get; set;}

        public string nome_cliente { get; set;}

        public string endereco_cliente { get; set;}

    }
}
