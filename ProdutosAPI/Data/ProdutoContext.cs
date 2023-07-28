using Microsoft.EntityFrameworkCore;
using ProdutosAPI.Models;

namespace ProdutosAPI.Data;

public class ItemContext : DbContext
{
    public ItemContext(DbContextOptions<ItemContext> options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Item>()
           .HasKey(item => new { item.pedidoId, item.produtoId });
        builder.Entity<Item>()
           .HasOne(item => item.Pedido)
           .WithMany(pedido => pedido.Item_Produtos)
           .HasForeignKey(item => item.pedidoId);

        builder.Entity<Item>()
            .HasOne(item => item.Produto)
            .WithMany(produto => produto.Item_Produtos)
            .HasForeignKey(item => item.produtoId);
    }

    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Cliente> Clientes { get; set;}
    public DbSet<Pedido> Pedidos { get; set; }
    public DbSet<Item> Items { get; set; }
}

