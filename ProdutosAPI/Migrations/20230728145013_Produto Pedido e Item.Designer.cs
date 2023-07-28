﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProdutosAPI.Data;

#nullable disable

namespace ProdutosAPI.Migrations
{
    [DbContext(typeof(ItemContext))]
    [Migration("20230728145013_Produto Pedido e Item")]
    partial class ProdutoPedidoeItem
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ProdutosAPI.Models.Cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("endereco_cliente")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("nome_cliente")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ProdutosAPI.Models.Item", b =>
                {
                    b.Property<int?>("pedidoId")
                        .HasColumnType("int");

                    b.Property<int?>("produtoId")
                        .HasColumnType("int");

                    b.Property<int>("qtd_pedido")
                        .HasColumnType("int");

                    b.Property<float>("valor_item")
                        .HasColumnType("float");

                    b.HasKey("pedidoId", "produtoId");

                    b.HasIndex("produtoId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("ProdutosAPI.Models.Pedido", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("clienteId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("data_pedido")
                        .HasColumnType("date");

                    b.Property<float>("valor_total")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.HasIndex("clienteId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("ProdutosAPI.Models.Produto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("categoria")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("nome_produto")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<float>("valor_produto")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("ProdutosAPI.Models.Item", b =>
                {
                    b.HasOne("ProdutosAPI.Models.Pedido", "Pedido")
                        .WithMany("Item_Produtos")
                        .HasForeignKey("pedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProdutosAPI.Models.Produto", "Produto")
                        .WithMany("Item_Produtos")
                        .HasForeignKey("produtoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("ProdutosAPI.Models.Pedido", b =>
                {
                    b.HasOne("ProdutosAPI.Models.Cliente", "Cliente")
                        .WithMany("Pedidos")
                        .HasForeignKey("clienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("ProdutosAPI.Models.Cliente", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("ProdutosAPI.Models.Pedido", b =>
                {
                    b.Navigation("Item_Produtos");
                });

            modelBuilder.Entity("ProdutosAPI.Models.Produto", b =>
                {
                    b.Navigation("Item_Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}