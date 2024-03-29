﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WordVision.ec.Infrastructure.Data.Contexts;

namespace WordVision.ec.Infrastructure.Data.Migrations.RegistroDb
{
    [DbContext(typeof(RegistroDbContext))]
    [Migration("20210506032214_Migrationv4")]
    partial class Migrationv4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AspNetCoreHero.EntityFrameworkCore.AuditTrail.Models.Audit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AffectedColumns")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("NewValues")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OldValues")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimaryKey")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TableName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AuditLogs");
                });

            modelBuilder.Entity("WordVision.ec.Domain.Entities.Registro.Colaborador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Identificacion")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("LugarTrabajo")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("PrimerNombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("SegundoNombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Colaboradores");
                });

            modelBuilder.Entity("WordVision.ec.Domain.Entities.Registro.Documento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescripcionAcepto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<int?>("IdColaborador")
                        .HasColumnType("int");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)");

                    b.HasKey("Id");

                    b.HasIndex("IdColaborador");

                    b.ToTable("Documentos");
                });

            modelBuilder.Entity("WordVision.ec.Domain.Entities.Registro.Firma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ColaboradoresId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdColaborador")
                        .HasColumnType("int");

                    b.Property<int>("IdDocumento")
                        .HasColumnType("int");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("RutaFirma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ColaboradoresId");

                    b.ToTable("Firmas");
                });

            modelBuilder.Entity("WordVision.ec.Domain.Entities.Registro.Formulario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alergias")
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)");

                    b.Property<string>("CalleResidencia")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CalleSecundariaResidencia")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CedulaDependiente")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CedulaExtranjero")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CelularContacto")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("CiudadResidencia")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CiudadaniaExtranjero")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CodigoArea")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("CodigoAreaContacto")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreenciaReligiosa")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("CuentaBancaria")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DiscapacidadSN")
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("DobleCiudadaniaSN")
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("EdadContacto")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("EmailContacto")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("EstadoCivil")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Etnia")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<decimal>("FamiliaDiscapacidad")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("FamiliaDiscapacidadRelacion")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FamiliaDiscapacidadSN")
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<decimal>("FamiliaPorcentajeDiscapacidad")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("FamiliaTipoDiscapacidad")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("FecNacimientoDependiente")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("FormacionAcademica")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("GeneroDependiente")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("IdColaborador")
                        .HasColumnType("int");

                    b.Property<string>("Idioma")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Iglesia")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("InfoResidencia")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nacionalidad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NumCasaResidencia")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PaisCiudadania")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PaisResidencia")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("PorcentajeDiscapacidad")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PorcentajeEscrito")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PorcentajeHablado")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Preexistencia")
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)");

                    b.Property<string>("PrimerApellidoContacto")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PrimerApellidoDependiente")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PrimerNombreContacto")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PrimerNombreDependiente")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ProvinciaResidencia")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ReferenciaResidencia")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SectorResidencia")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SegundoApellidoContacto")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SegundoApellidoDependiente")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SegundoNombreContacto")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SegundoNombreDependiente")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telefono")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("TelefonoContacto")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("TipoContacto")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TipoDependiente")
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("TipoDiscapacidad")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TipoSangre")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<DateTime>("VigDesdeDependiente")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("VigHastaDependiente")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("VigenciaDesde")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("VigenciaHasta")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdColaborador");

                    b.ToTable("Formularios");
                });

            modelBuilder.Entity("WordVision.ec.Domain.Entities.Registro.Pregunta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescripcionAcepto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescripcionUrl1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescripcionUrl2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("IdDocumento")
                        .HasColumnType("int");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumPregunta")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)");

                    b.Property<string>("Url1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url2")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdDocumento");

                    b.ToTable("Preguntas");
                });

            modelBuilder.Entity("WordVision.ec.Domain.Entities.Registro.Respuesta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ColaboradoresId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("DescRespuesta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdColaborador")
                        .HasColumnType("int");

                    b.Property<int>("IdDocumento")
                        .HasColumnType("int");

                    b.Property<int>("IdPregunta")
                        .HasColumnType("int");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ColaboradoresId");

                    b.ToTable("Respuestas");
                });

            modelBuilder.Entity("WordVision.ec.Domain.Entities.Registro.Documento", b =>
                {
                    b.HasOne("WordVision.ec.Domain.Entities.Registro.Colaborador", null)
                        .WithMany("Documentos")
                        .HasForeignKey("IdColaborador");
                });

            modelBuilder.Entity("WordVision.ec.Domain.Entities.Registro.Firma", b =>
                {
                    b.HasOne("WordVision.ec.Domain.Entities.Registro.Colaborador", "Colaboradores")
                        .WithMany()
                        .HasForeignKey("ColaboradoresId");

                    b.Navigation("Colaboradores");
                });

            modelBuilder.Entity("WordVision.ec.Domain.Entities.Registro.Formulario", b =>
                {
                    b.HasOne("WordVision.ec.Domain.Entities.Registro.Colaborador", "Colaboradores")
                        .WithMany("Formularios")
                        .HasForeignKey("IdColaborador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Colaboradores");
                });

            modelBuilder.Entity("WordVision.ec.Domain.Entities.Registro.Pregunta", b =>
                {
                    b.HasOne("WordVision.ec.Domain.Entities.Registro.Documento", "Documentos")
                        .WithMany("Preguntas")
                        .HasForeignKey("IdDocumento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Documentos");
                });

            modelBuilder.Entity("WordVision.ec.Domain.Entities.Registro.Respuesta", b =>
                {
                    b.HasOne("WordVision.ec.Domain.Entities.Registro.Colaborador", "Colaboradores")
                        .WithMany()
                        .HasForeignKey("ColaboradoresId");

                    b.Navigation("Colaboradores");
                });

            modelBuilder.Entity("WordVision.ec.Domain.Entities.Registro.Colaborador", b =>
                {
                    b.Navigation("Documentos");

                    b.Navigation("Formularios");
                });

            modelBuilder.Entity("WordVision.ec.Domain.Entities.Registro.Documento", b =>
                {
                    b.Navigation("Preguntas");
                });
#pragma warning restore 612, 618
        }
    }
}
