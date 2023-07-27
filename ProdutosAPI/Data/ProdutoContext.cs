using Microsoft.EntityFrameworkCore;
using ProdutosAPI.Models;

namespace ProdutosAPI.Data;

public class PedidoContext : DbContext
{
    public PedidoContext(DbContextOptions<PedidoContext> options) : base(options)
    {

    } 
     public DbSet<Produto> Produtos { get; set; }
    public DbSet<Cliente> Clientes { get; set;}
    public DbSet<Pedido> Pedidos { get; set; }
}

