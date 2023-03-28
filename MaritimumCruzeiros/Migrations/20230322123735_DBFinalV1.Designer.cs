﻿// <auto-generated />
using System;
using MaritimumCruzeiros.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CruzeirosEmporio.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20230322123735_DBFinalV1")]
    partial class DBFinalV1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MaritimumCruzeiros.Models.Cabine", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_CABINE");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<int>("CapacidadeMaxima")
                        .HasColumnType("int")
                        .HasColumnName("CAPACIDADE_MAXIMA");

                    b.Property<int>("NavioId")
                        .HasColumnType("int")
                        .HasColumnName("ID_NAVIO");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NUMERO");

                    b.Property<string>("Piso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PISO");

                    b.Property<int>("TipoCabineId")
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_CABINE");

                    b.HasKey("Id");

                    b.HasIndex("NavioId");

                    b.HasIndex("TipoCabineId");

                    b.ToTable("CABINES", (string)null);
                });

            modelBuilder.Entity("MaritimumCruzeiros.Models.CabineTripulante", b =>
                {
                    b.Property<int?>("CabineTripulanteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_CABINE_TRIPULANTE");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("CabineTripulanteId"), 1L, 1);

                    b.Property<int>("CabineId")
                        .HasColumnType("int")
                        .HasColumnName("ID_CABINE");

                    b.Property<int>("CruzeiroId")
                        .HasColumnType("int")
                        .HasColumnName("ID_CRUZEIRO");

                    b.Property<int>("TripulanteId")
                        .HasColumnType("int")
                        .HasColumnName("ID_TRIPULANTE");

                    b.HasKey("CabineTripulanteId");

                    b.HasIndex("CabineId");

                    b.HasIndex("CruzeiroId");

                    b.HasIndex("TripulanteId");

                    b.ToTable("CABINE_TRIPULANTE", (string)null);
                });

            modelBuilder.Entity("MaritimumCruzeiros.Models.Cruzeiro", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_CRUZEIRO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<DateTime>("DataChegada")
                        .HasColumnType("datetime2")
                        .HasColumnName("DATA_CHEGADA");

                    b.Property<DateTime>("DataPartida")
                        .HasColumnType("datetime2")
                        .HasColumnName("DATA_PARTIDA");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DESCRICAO");

                    b.Property<int?>("NavioId")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("ID_NAVIO");

                    b.Property<string>("NomeExpedicao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("NOME_EXPEDICAO");

                    b.HasKey("Id");

                    b.HasIndex("NavioId");

                    b.ToTable("CRUZEIROS", (string)null);
                });

            modelBuilder.Entity("MaritimumCruzeiros.Models.Navio", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_NAVIO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<int>("CapacidadePessoas")
                        .HasColumnType("int")
                        .HasColumnName("CAPACIDADE_PESSOAS");

                    b.Property<string>("Nome")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("NOME");

                    b.HasKey("Id");

                    b.ToTable("NAVIOS", (string)null);
                });

            modelBuilder.Entity("MaritimumCruzeiros.Models.Pessoa", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_PESSOA");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DOCUMENTO");

                    b.Property<int>("Idade")
                        .HasColumnType("int")
                        .HasColumnName("IDADE");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("NOME");

                    b.Property<int>("SexoPessoaId")
                        .HasColumnType("int")
                        .HasColumnName("ID_SEXO_PESSOA");

                    b.HasKey("Id");

                    b.HasIndex("SexoPessoaId");

                    b.ToTable("PESSOAS", (string)null);
                });

            modelBuilder.Entity("MaritimumCruzeiros.Models.SexoPessoa", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_SEXO_PESSOA");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("SEXO");

                    b.HasKey("Id");

                    b.ToTable("SEXO_PESSOA", (string)null);
                });

            modelBuilder.Entity("MaritimumCruzeiros.Models.TipoCabine", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_CABINE");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DESCRICAO");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TIPO");

                    b.HasKey("Id");

                    b.ToTable("TIPO_CABINE", (string)null);
                });

            modelBuilder.Entity("MaritimumCruzeiros.Models.TipoTripulante", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_TRIPULANTE");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TIPO");

                    b.HasKey("Id");

                    b.ToTable("TIPO_TRIPULATE", (string)null);
                });

            modelBuilder.Entity("MaritimumCruzeiros.Models.Tripulante", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_TRIPULANTE");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<int?>("CabineTripulanteId")
                        .HasColumnType("int")
                        .HasColumnName("ID_CABINE_TRIPULANTE");

                    b.Property<int>("CruzeiroId")
                        .HasColumnType("int")
                        .HasColumnName("ID_CRUZEIRO");

                    b.Property<int>("PessoaId")
                        .HasColumnType("int")
                        .HasColumnName("ID_PESSOA");

                    b.Property<int>("TipoTripulanteId")
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_TRIPULANTE");

                    b.HasKey("Id");

                    b.HasIndex("CabineTripulanteId");

                    b.HasIndex("CruzeiroId");

                    b.HasIndex("PessoaId");

                    b.HasIndex("TipoTripulanteId");

                    b.ToTable("TRIPULANTES", (string)null);
                });

            modelBuilder.Entity("MaritimumCruzeiros.Models.Cabine", b =>
                {
                    b.HasOne("MaritimumCruzeiros.Models.Navio", "Navio")
                        .WithMany("Cabines")
                        .HasForeignKey("NavioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MaritimumCruzeiros.Models.TipoCabine", "TipoCabine")
                        .WithMany()
                        .HasForeignKey("TipoCabineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Navio");

                    b.Navigation("TipoCabine");
                });

            modelBuilder.Entity("MaritimumCruzeiros.Models.CabineTripulante", b =>
                {
                    b.HasOne("MaritimumCruzeiros.Models.Cabine", "Cabine")
                        .WithMany()
                        .HasForeignKey("CabineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MaritimumCruzeiros.Models.Cruzeiro", "Cruzeiro")
                        .WithMany()
                        .HasForeignKey("CruzeiroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MaritimumCruzeiros.Models.Tripulante", "Tripulante")
                        .WithMany()
                        .HasForeignKey("TripulanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cabine");

                    b.Navigation("Cruzeiro");

                    b.Navigation("Tripulante");
                });

            modelBuilder.Entity("MaritimumCruzeiros.Models.Cruzeiro", b =>
                {
                    b.HasOne("MaritimumCruzeiros.Models.Navio", "Navio")
                        .WithMany()
                        .HasForeignKey("NavioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Navio");
                });

            modelBuilder.Entity("MaritimumCruzeiros.Models.Pessoa", b =>
                {
                    b.HasOne("MaritimumCruzeiros.Models.SexoPessoa", "SexoPessoa")
                        .WithMany()
                        .HasForeignKey("SexoPessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SexoPessoa");
                });

            modelBuilder.Entity("MaritimumCruzeiros.Models.Tripulante", b =>
                {
                    b.HasOne("MaritimumCruzeiros.Models.CabineTripulante", "CabineTripulante")
                        .WithMany()
                        .HasForeignKey("CabineTripulanteId");

                    b.HasOne("MaritimumCruzeiros.Models.Cruzeiro", "Cruzeiro")
                        .WithMany("Tripulantes")
                        .HasForeignKey("CruzeiroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MaritimumCruzeiros.Models.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MaritimumCruzeiros.Models.TipoTripulante", "TipoTripulante")
                        .WithMany()
                        .HasForeignKey("TipoTripulanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CabineTripulante");

                    b.Navigation("Cruzeiro");

                    b.Navigation("Pessoa");

                    b.Navigation("TipoTripulante");
                });

            modelBuilder.Entity("MaritimumCruzeiros.Models.Cruzeiro", b =>
                {
                    b.Navigation("Tripulantes");
                });

            modelBuilder.Entity("MaritimumCruzeiros.Models.Navio", b =>
                {
                    b.Navigation("Cabines");
                });
#pragma warning restore 612, 618
        }
    }
}
