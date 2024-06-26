﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Underage.data;

#nullable disable

namespace Underage.Migrations
{
    [DbContext(typeof(UnderageDbContext))]
    [Migration("20240508115402_v.final")]
    partial class vfinal
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("Underage.models.DadosPessoais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DataNascimento")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailResponsavel")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeResponsavel")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TelefoneResponsavel")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DadosPessoais");
                });
#pragma warning restore 612, 618
        }
    }
}
