﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NutrInfo.Persistence.Contextos;

#nullable disable

namespace NutrInfo.Persistence.Migrations
{
    [DbContext(typeof(NutrInfoContext))]
    partial class NutrInfoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NutrInfo.Domain.Departamento", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PermissaoID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PermissaoID");

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("NutrInfo.Domain.Endereco", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EstadoID")
                        .HasColumnType("int");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("EstadoID");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("NutrInfo.Domain.Estado", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("NutrInfo.Domain.Funcionario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataAdmissao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDemissão")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataNasc")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DepartamentoID")
                        .HasColumnType("int");

                    b.Property<int?>("EnderecoID")
                        .HasColumnType("int");

                    b.Property<string>("EstadoCivil")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LoginID")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DepartamentoID");

                    b.HasIndex("EnderecoID");

                    b.HasIndex("LoginID");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("NutrInfo.Domain.Login", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("NutrInfo.Domain.Permissao", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("TipoPermissao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Permissoes");
                });

            modelBuilder.Entity("NutrInfo.Domain.Departamento", b =>
                {
                    b.HasOne("NutrInfo.Domain.Permissao", null)
                        .WithMany("Departamentos")
                        .HasForeignKey("PermissaoID");
                });

            modelBuilder.Entity("NutrInfo.Domain.Endereco", b =>
                {
                    b.HasOne("NutrInfo.Domain.Estado", null)
                        .WithMany("Enderecos")
                        .HasForeignKey("EstadoID");
                });

            modelBuilder.Entity("NutrInfo.Domain.Funcionario", b =>
                {
                    b.HasOne("NutrInfo.Domain.Departamento", null)
                        .WithMany("Funcionarios")
                        .HasForeignKey("DepartamentoID");

                    b.HasOne("NutrInfo.Domain.Endereco", null)
                        .WithMany("Funcionarios")
                        .HasForeignKey("EnderecoID");

                    b.HasOne("NutrInfo.Domain.Login", null)
                        .WithMany("Funcionarios")
                        .HasForeignKey("LoginID");
                });

            modelBuilder.Entity("NutrInfo.Domain.Departamento", b =>
                {
                    b.Navigation("Funcionarios");
                });

            modelBuilder.Entity("NutrInfo.Domain.Endereco", b =>
                {
                    b.Navigation("Funcionarios");
                });

            modelBuilder.Entity("NutrInfo.Domain.Estado", b =>
                {
                    b.Navigation("Enderecos");
                });

            modelBuilder.Entity("NutrInfo.Domain.Login", b =>
                {
                    b.Navigation("Funcionarios");
                });

            modelBuilder.Entity("NutrInfo.Domain.Permissao", b =>
                {
                    b.Navigation("Departamentos");
                });
#pragma warning restore 612, 618
        }
    }
}
