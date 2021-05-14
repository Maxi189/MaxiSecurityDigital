﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServicoPortaria.Infra.Data.Contexto;

namespace ServicoPortaria.Infra.Data.Migrations
{
    [DbContext(typeof(PortariaContext))]
    [Migration("20210430141654_Portaria")]
    partial class Portaria
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ServicoPortaria.Domain.Entities.Apartamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bloco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CondominioId")
                        .HasColumnType("int");

                    b.Property<int>("IdCondominio")
                        .HasColumnType("int");

                    b.Property<int>("IdMorador")
                        .HasColumnType("int");

                    b.Property<int>("IdPredio")
                        .HasColumnType("int");

                    b.Property<int?>("MoradorId")
                        .HasColumnType("int");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<int?>("PredioId")
                        .HasColumnType("int");

                    b.Property<string>("Ramal")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CondominioId");

                    b.HasIndex("MoradorId");

                    b.HasIndex("PredioId");

                    b.ToTable("Apartamento");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Entities.Condominio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CEP")
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("CodPostal")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Estado")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Pais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Provincia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rua")
                        .HasMaxLength(90)
                        .HasColumnType("nvarchar(90)");

                    b.HasKey("Id");

                    b.ToTable("Condominio");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Entities.Garagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CondominioId")
                        .HasColumnType("int");

                    b.Property<int>("IdCondominio")
                        .HasColumnType("int");

                    b.Property<int>("IdPredio")
                        .HasColumnType("int");

                    b.Property<int?>("PredioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CondominioId");

                    b.HasIndex("PredioId");

                    b.ToTable("Garagem");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Entities.Morador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CEP")
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("CPF")
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("Celular")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Cidade")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("CodigoPostal")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("CondominioId")
                        .HasColumnType("int");

                    b.Property<string>("DocCivil")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("EMail")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Estado")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("Fixo")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("IdCondominio")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Pais")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Provincia")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("RG")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Rua")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Sexo")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.HasIndex("CondominioId");

                    b.ToTable("Morador");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Entities.Predio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CondominioId")
                        .HasColumnType("int");

                    b.Property<int>("IdCondominio")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CondominioId");

                    b.ToTable("Predio");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Entities.PrestadorServicos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("nvarchar(18)");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<int?>("CondominioId")
                        .HasColumnType("int");

                    b.Property<int>("IdCondominio")
                        .HasColumnType("int");

                    b.Property<int>("IdPredio")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int?>("PredioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CondominioId");

                    b.HasIndex("PredioId");

                    b.ToTable("PrestadorServicos");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Entities.RecuperacaoSenha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("EMail")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("RecuperacaoSenha");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Entities.Sindico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<int?>("CondominioId")
                        .HasColumnType("int");

                    b.Property<string>("DocCivil")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("EMail")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("IdCondominio")
                        .HasColumnType("int");

                    b.Property<int>("IdPredio")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("PredioId")
                        .HasColumnType("int");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.HasIndex("CondominioId");

                    b.HasIndex("PredioId");

                    b.ToTable("Sindico");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NivelDeAcesso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Entities.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CondominioId")
                        .HasColumnType("int");

                    b.Property<int>("IdCondominio")
                        .HasColumnType("int");

                    b.Property<int>("IdMorador")
                        .HasColumnType("int");

                    b.Property<int>("IdPredio")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("MoradorId")
                        .HasColumnType("int");

                    b.Property<string>("Placa")
                        .HasColumnType("nvarchar(8)");

                    b.Property<int?>("PredioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CondominioId");

                    b.HasIndex("MoradorId");

                    b.HasIndex("PredioId");

                    b.ToTable("Veiculo");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Entities.Visita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ApartamentoId")
                        .HasColumnType("int");

                    b.Property<int?>("CondominioId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataChegada")
                        .HasColumnType("date");

                    b.Property<DateTime>("DataSaida")
                        .HasColumnType("date");

                    b.Property<TimeSpan>("HoraChegada")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("time");

                    b.Property<TimeSpan>("HoraSaida")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("time");

                    b.Property<int>("IdApartamento")
                        .HasColumnType("int");

                    b.Property<int>("IdCondominio")
                        .HasColumnType("int");

                    b.Property<int>("IdMorador")
                        .HasColumnType("int");

                    b.Property<int>("IdPredio")
                        .HasColumnType("int");

                    b.Property<int>("IdVisitante")
                        .HasColumnType("int");

                    b.Property<int?>("PredioId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Saida")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("ApartamentoId");

                    b.HasIndex("CondominioId");

                    b.HasIndex("PredioId");

                    b.ToTable("Visita");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Entities.Visitante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("DocCivil")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("EMail")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Fixo")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("RG")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Visitante");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Entities.Apartamento", b =>
                {
                    b.HasOne("ServicoPortaria.Domain.Entities.Condominio", "Condominio")
                        .WithMany()
                        .HasForeignKey("CondominioId");

                    b.HasOne("ServicoPortaria.Domain.Entities.Morador", "Morador")
                        .WithMany()
                        .HasForeignKey("MoradorId");

                    b.HasOne("ServicoPortaria.Domain.Entities.Predio", "Predio")
                        .WithMany()
                        .HasForeignKey("PredioId");

                    b.Navigation("Condominio");

                    b.Navigation("Morador");

                    b.Navigation("Predio");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Entities.Garagem", b =>
                {
                    b.HasOne("ServicoPortaria.Domain.Entities.Condominio", "Condominio")
                        .WithMany()
                        .HasForeignKey("CondominioId");

                    b.HasOne("ServicoPortaria.Domain.Entities.Predio", "Predio")
                        .WithMany()
                        .HasForeignKey("PredioId");

                    b.Navigation("Condominio");

                    b.Navigation("Predio");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Entities.Morador", b =>
                {
                    b.HasOne("ServicoPortaria.Domain.Entities.Condominio", "Condominio")
                        .WithMany()
                        .HasForeignKey("CondominioId");

                    b.Navigation("Condominio");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Entities.Predio", b =>
                {
                    b.HasOne("ServicoPortaria.Domain.Entities.Condominio", "Condominio")
                        .WithMany()
                        .HasForeignKey("CondominioId");

                    b.Navigation("Condominio");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Entities.PrestadorServicos", b =>
                {
                    b.HasOne("ServicoPortaria.Domain.Entities.Condominio", "Condominio")
                        .WithMany()
                        .HasForeignKey("CondominioId");

                    b.HasOne("ServicoPortaria.Domain.Entities.Predio", "Predio")
                        .WithMany()
                        .HasForeignKey("PredioId");

                    b.Navigation("Condominio");

                    b.Navigation("Predio");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Entities.RecuperacaoSenha", b =>
                {
                    b.HasOne("ServicoPortaria.Domain.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Entities.Sindico", b =>
                {
                    b.HasOne("ServicoPortaria.Domain.Entities.Condominio", "Condominio")
                        .WithMany()
                        .HasForeignKey("CondominioId");

                    b.HasOne("ServicoPortaria.Domain.Entities.Predio", "Predio")
                        .WithMany()
                        .HasForeignKey("PredioId");

                    b.Navigation("Condominio");

                    b.Navigation("Predio");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Entities.Veiculo", b =>
                {
                    b.HasOne("ServicoPortaria.Domain.Entities.Condominio", "Condominio")
                        .WithMany()
                        .HasForeignKey("CondominioId");

                    b.HasOne("ServicoPortaria.Domain.Entities.Morador", "Morador")
                        .WithMany()
                        .HasForeignKey("MoradorId");

                    b.HasOne("ServicoPortaria.Domain.Entities.Predio", "Predio")
                        .WithMany()
                        .HasForeignKey("PredioId");

                    b.Navigation("Condominio");

                    b.Navigation("Morador");

                    b.Navigation("Predio");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Entities.Visita", b =>
                {
                    b.HasOne("ServicoPortaria.Domain.Entities.Apartamento", "Apartamento")
                        .WithMany()
                        .HasForeignKey("ApartamentoId");

                    b.HasOne("ServicoPortaria.Domain.Entities.Condominio", "Condominio")
                        .WithMany()
                        .HasForeignKey("CondominioId");

                    b.HasOne("ServicoPortaria.Domain.Entities.Predio", "Predio")
                        .WithMany()
                        .HasForeignKey("PredioId");

                    b.Navigation("Apartamento");

                    b.Navigation("Condominio");

                    b.Navigation("Predio");
                });
#pragma warning restore 612, 618
        }
    }
}
