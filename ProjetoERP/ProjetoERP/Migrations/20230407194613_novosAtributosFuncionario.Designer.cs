﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoErp.Data;

#nullable disable

namespace ProjetoErp.Migrations
{
    [DbContext(typeof(ProjetoDBContext))]
    [Migration("20230407194613_novosAtributosFuncionario")]
    partial class novosAtributosFuncionario
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjetoErp.Models.FuncionarioModel", b =>
                {
                    b.Property<int>("id_FN")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_FN"));

                    b.Property<int?>("anoContratacao_FN")
                        .HasColumnType("int");

                    b.Property<string>("cargo_FN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("documentoCpf_FN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("enderecoEmail_FN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("enderecoLocal_FN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome_FN")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("numeroTelefone_FN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("salario_FN")
                        .HasColumnType("float");

                    b.HasKey("id_FN");

                    b.ToTable("Funcionarios");
                });
#pragma warning restore 612, 618
        }
    }
}