﻿// <auto-generated />
using System;
using Ame.BD;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ame.Migrations
{
    [DbContext(typeof(BD_Context))]
    [Migration("20240623211520_AddSobreConsultoria")]
    partial class AddSobreConsultoria
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ame.Modelo.AlimentacaoCrianca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("FichaBebeTresMesesId")
                        .HasColumnType("int");

                    b.Property<string>("Pergunta22")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta23")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta24")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta25")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta26")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta27")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta28")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta29")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta30")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FichaBebeTresMesesId");

                    b.ToTable("AlimentacaoCrianca");
                });

            modelBuilder.Entity("Ame.Modelo.AmbienteSono", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("FichaBebeTresMesesId")
                        .HasColumnType("int");

                    b.Property<string>("Pergunta74")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta75")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta76")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta77")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta78")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta79")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta80")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta81")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta82")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta83")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta84")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta85")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta86")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta87")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta88")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta89a")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta89b")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FichaBebeTresMesesId");

                    b.ToTable("AmbienteSono");
                });

            modelBuilder.Entity("Ame.Modelo.DinamicaFamiliar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("FichaBebeTresMesesId")
                        .HasColumnType("int");

                    b.Property<string>("Pergunta43")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta44")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta45")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta46")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta47")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta47a")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta47b")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta48")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta49")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta50")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta51")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta52")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta53")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta54")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta55")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta56")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta57")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta58")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta59")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FichaBebeTresMesesId");

                    b.ToTable("DinamicaFamiliar");
                });

            modelBuilder.Entity("Ame.Modelo.FichaBebeTresMeses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Contrato")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Data_Nascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Idade_Crianca")
                        .HasColumnType("float");

                    b.Property<string>("Nome_Crianca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome_Mae")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome_Pai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome_Pediatra")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profissao_Mae")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profissao_Pai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FichaBebeTresMeses");
                });

            modelBuilder.Entity("Ame.Modelo.NivelDeAtividade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("FichaBebeTresMesesId")
                        .HasColumnType("int");

                    b.Property<string>("Pergunta14")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta15")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta16")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta17")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta18")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta19")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta20")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta21")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FichaBebeTresMesesId");

                    b.ToTable("NivelDeAtividade");
                });

            modelBuilder.Entity("Ame.Modelo.ProblemaSono", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("FichaBebeTresMesesId")
                        .HasColumnType("int");

                    b.Property<string>("Pergunta60")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta61")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta61a")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta62")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta63")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta64")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta65")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta66")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta67")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta68")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta69")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta70")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta71")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta72")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta73")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FichaBebeTresMesesId");

                    b.ToTable("ProblemaSono");
                });

            modelBuilder.Entity("Ame.Modelo.SaudeDaCrianca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("FichaBebeTresMesesId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Pergunta1")
                        .HasColumnType("datetime2");

                    b.Property<string>("Pergunta10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta13")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta9")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FichaBebeTresMesesId");

                    b.ToTable("SaudeDaCriancas");
                });

            modelBuilder.Entity("Ame.Modelo.SobreConsultoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("FichaBebeTresMesesId")
                        .HasColumnType("int");

                    b.Property<string>("Pergunta90")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta91")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta92")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FichaBebeTresMesesId");

                    b.ToTable("SobreConsultoria");
                });

            modelBuilder.Entity("Ame.Modelo.SobrePais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("FichaBebeTresMesesId")
                        .HasColumnType("int");

                    b.Property<string>("Pergunta34")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta35")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta35v1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta36")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta37")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta38")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta39")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta40")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta40v1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta41")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta42")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FichaBebeTresMesesId");

                    b.ToTable("SobrePais");
                });

            modelBuilder.Entity("Ame.Modelo.TemperamentoCrianca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("FichaBebeTresMesesId")
                        .HasColumnType("int");

                    b.Property<string>("Pergunta31")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta32")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pergunta33")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FichaBebeTresMesesId");

                    b.ToTable("TemperamentoCrianca");
                });

            modelBuilder.Entity("Ame.Modelo.AlimentacaoCrianca", b =>
                {
                    b.HasOne("Ame.Modelo.FichaBebeTresMeses", "FichaBebeTresMeses")
                        .WithMany("AlimentacaoCrianca")
                        .HasForeignKey("FichaBebeTresMesesId");

                    b.Navigation("FichaBebeTresMeses");
                });

            modelBuilder.Entity("Ame.Modelo.AmbienteSono", b =>
                {
                    b.HasOne("Ame.Modelo.FichaBebeTresMeses", "FichaBebeTresMeses")
                        .WithMany("AmbienteSono")
                        .HasForeignKey("FichaBebeTresMesesId");

                    b.Navigation("FichaBebeTresMeses");
                });

            modelBuilder.Entity("Ame.Modelo.DinamicaFamiliar", b =>
                {
                    b.HasOne("Ame.Modelo.FichaBebeTresMeses", "FichaBebeTresMeses")
                        .WithMany("DinamicaFamiliar")
                        .HasForeignKey("FichaBebeTresMesesId");

                    b.Navigation("FichaBebeTresMeses");
                });

            modelBuilder.Entity("Ame.Modelo.NivelDeAtividade", b =>
                {
                    b.HasOne("Ame.Modelo.FichaBebeTresMeses", "FichaBebeTresMeses")
                        .WithMany("NivelAtividade")
                        .HasForeignKey("FichaBebeTresMesesId");

                    b.Navigation("FichaBebeTresMeses");
                });

            modelBuilder.Entity("Ame.Modelo.ProblemaSono", b =>
                {
                    b.HasOne("Ame.Modelo.FichaBebeTresMeses", "FichaBebeTresMeses")
                        .WithMany("ProblemaSono")
                        .HasForeignKey("FichaBebeTresMesesId");

                    b.Navigation("FichaBebeTresMeses");
                });

            modelBuilder.Entity("Ame.Modelo.SaudeDaCrianca", b =>
                {
                    b.HasOne("Ame.Modelo.FichaBebeTresMeses", "FichaBebeTresMeses")
                        .WithMany("SaudeCrianca")
                        .HasForeignKey("FichaBebeTresMesesId");

                    b.Navigation("FichaBebeTresMeses");
                });

            modelBuilder.Entity("Ame.Modelo.SobreConsultoria", b =>
                {
                    b.HasOne("Ame.Modelo.FichaBebeTresMeses", "FichaBebeTresMeses")
                        .WithMany("SobreConsultoria")
                        .HasForeignKey("FichaBebeTresMesesId");

                    b.Navigation("FichaBebeTresMeses");
                });

            modelBuilder.Entity("Ame.Modelo.SobrePais", b =>
                {
                    b.HasOne("Ame.Modelo.FichaBebeTresMeses", "FichaBebeTresMeses")
                        .WithMany("SobrePais")
                        .HasForeignKey("FichaBebeTresMesesId");

                    b.Navigation("FichaBebeTresMeses");
                });

            modelBuilder.Entity("Ame.Modelo.TemperamentoCrianca", b =>
                {
                    b.HasOne("Ame.Modelo.FichaBebeTresMeses", "FichaBebeTresMeses")
                        .WithMany("TemperamentoCrianca")
                        .HasForeignKey("FichaBebeTresMesesId");

                    b.Navigation("FichaBebeTresMeses");
                });

            modelBuilder.Entity("Ame.Modelo.FichaBebeTresMeses", b =>
                {
                    b.Navigation("AlimentacaoCrianca");

                    b.Navigation("AmbienteSono");

                    b.Navigation("DinamicaFamiliar");

                    b.Navigation("NivelAtividade");

                    b.Navigation("ProblemaSono");

                    b.Navigation("SaudeCrianca");

                    b.Navigation("SobreConsultoria");

                    b.Navigation("SobrePais");

                    b.Navigation("TemperamentoCrianca");
                });
#pragma warning restore 612, 618
        }
    }
}
