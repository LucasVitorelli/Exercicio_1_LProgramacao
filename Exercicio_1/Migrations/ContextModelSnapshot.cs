﻿// <auto-generated />
using System;
using Exercicio_1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Exercicio_1.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Exercicio_1.Models.Aluno", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("aniversario")
                        .HasColumnType("datetime2");

                    b.Property<int>("cursoID")
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("periodo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("cursoID");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("Exercicio_1.Models.Atendimento", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("alunoID")
                        .HasColumnType("int");

                    b.Property<DateTime>("data")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("hora")
                        .HasColumnType("datetime2");

                    b.Property<int>("salaID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("alunoID");

                    b.HasIndex("salaID");

                    b.ToTable("Atendimento");
                });

            modelBuilder.Entity("Exercicio_1.Models.Curso", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("id");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("Exercicio_1.Models.Sala", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("equipamentos")
                        .HasColumnType("int");

                    b.Property<string>("situacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("id");

                    b.ToTable("Sala");
                });

            modelBuilder.Entity("Exercicio_1.Models.Aluno", b =>
                {
                    b.HasOne("Exercicio_1.Models.Curso", "curso")
                        .WithMany()
                        .HasForeignKey("cursoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("curso");
                });

            modelBuilder.Entity("Exercicio_1.Models.Atendimento", b =>
                {
                    b.HasOne("Exercicio_1.Models.Aluno", "aluno")
                        .WithMany()
                        .HasForeignKey("alunoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Exercicio_1.Models.Sala", "sala")
                        .WithMany()
                        .HasForeignKey("salaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("aluno");

                    b.Navigation("sala");
                });
#pragma warning restore 612, 618
        }
    }
}
