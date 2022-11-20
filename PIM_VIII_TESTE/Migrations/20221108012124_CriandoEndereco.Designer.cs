﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PIM_VIII_TESTE.Data;

namespace PIM_VIII_TESTE.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20221108012124_CriandoEndereco")]
    partial class CriandoEndereco
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PIM_VIII_TESTE.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int");

                    b.Property<string>("Bairro")
                        .HasColumnName("Bairro")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Cep")
                        .HasColumnName("Cep")
                        .HasColumnType("int");

                    b.Property<string>("Cidade")
                        .HasColumnName("Cidade")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Estado")
                        .HasColumnName("Estado")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Logradouro")
                        .HasColumnName("Logradouro")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Numero")
                        .HasColumnName("Numero")
                        .HasColumnType("int");

                    b.Property<int>("PessoaId")
                        .HasColumnName("PessoaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId")
                        .IsUnique();

                    b.ToTable("EnderecoTeste");
                });

            modelBuilder.Entity("PIM_VIII_TESTE.Models.Pessoas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .HasColumnName("Cpf")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .HasColumnName("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<long>("Telefone")
                        .HasColumnName("telefone")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("PessoasTeste");
                });

            modelBuilder.Entity("PIM_VIII_TESTE.Models.Endereco", b =>
                {
                    b.HasOne("PIM_VIII_TESTE.Models.Pessoas", "Pessoa")
                        .WithOne("Endereco")
                        .HasForeignKey("PIM_VIII_TESTE.Models.Endereco", "PessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
