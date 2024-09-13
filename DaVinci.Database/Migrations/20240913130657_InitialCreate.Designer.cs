﻿// <auto-generated />
using System;
using DaVinci.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DaVinci.Database.Migrations
{
    [DbContext(typeof(AzureDbContext))]
    [Migration("20240913130657_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DaVinci.Models.Clientes", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"));

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Cidade", "Cidade do cliente é obrigatorio");

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Cpf", "CPF do cliente é obrigatorio");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Email", "Email do cliente é obrigatorio");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Nome", "Nome do cliente é obrigatorio");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Sexo", "Sexo do cliente é obrigatorio");

                    b.HasKey("IdCliente");

                    b.ToTable("TB_DV_CLIENTE", (string)null);
                });

            modelBuilder.Entity("DaVinci.Models.Feedbacks", b =>
                {
                    b.Property<int>("IdFeedback")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFeedback"));

                    b.Property<int>("Avaliacao")
                        .HasColumnType("int");

                    b.Property<string>("Comentario")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("DataFeedback")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdProduto")
                        .HasColumnType("int");

                    b.HasKey("IdFeedback");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdProduto");

                    b.ToTable("TB_DV_FEEDBACK", (string)null);
                });

            modelBuilder.Entity("DaVinci.Models.Produtos", b =>
                {
                    b.Property<int>("IdProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProduto"));

                    b.Property<string>("Categoria")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<string>("Modelo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nome")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("IdProduto");

                    b.HasIndex("IdCliente");

                    b.ToTable("TB_DV_PRODUTO", (string)null);
                });

            modelBuilder.Entity("DaVinci.Models.Feedbacks", b =>
                {
                    b.HasOne("DaVinci.Models.Clientes", "Cliente")
                        .WithMany("Feedbacks")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DaVinci.Models.Produtos", "Produto")
                        .WithMany("Feedbacks")
                        .HasForeignKey("IdProduto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("DaVinci.Models.Produtos", b =>
                {
                    b.HasOne("DaVinci.Models.Clientes", "Cliente")
                        .WithMany("Produtos")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("DaVinci.Models.Clientes", b =>
                {
                    b.Navigation("Feedbacks");

                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("DaVinci.Models.Produtos", b =>
                {
                    b.Navigation("Feedbacks");
                });
#pragma warning restore 612, 618
        }
    }
}
