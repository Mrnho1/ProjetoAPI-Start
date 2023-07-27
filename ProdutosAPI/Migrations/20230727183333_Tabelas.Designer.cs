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
    [DbContext(typeof(PedidoContext))]
    [Migration("20230727183333_Tabelas")]
    partial class Tabelas
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

            modelBuilder.Entity("ProdutosAPI.Models.Pedido", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("data_pedido")
                        .HasColumnType("date");

                    b.Property<float>("valor_total")
                        .HasColumnType("float");

                    b.HasKey("id");

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
#pragma warning restore 612, 618
        }
    }
}