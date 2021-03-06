﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using aereolinia.Models;

namespace aereolinia.Migrations
{
    [DbContext(typeof(AereoLineaCTX))]
    [Migration("20200402181843_initialAereo")]
    partial class initialAereo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("aereolinia.Models.Aviones", b =>
                {
                    b.Property<int>("AvionesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Capacity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Eye")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AvionesID");

                    b.ToTable("Aviones");
                });

            modelBuilder.Entity("aereolinia.Models.Empleado", b =>
                {
                    b.Property<int>("EmpleadoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeEmpleadoID")
                        .HasColumnType("int");

                    b.HasKey("EmpleadoID");

                    b.HasIndex("TypeEmpleadoID");

                    b.ToTable("Empleado");
                });

            modelBuilder.Entity("aereolinia.Models.TypeEmpleado", b =>
                {
                    b.Property<int>("TypeEmpleadoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TypeEmpleadoID");

                    b.ToTable("TypeEmpleado");
                });

            modelBuilder.Entity("aereolinia.Models.Vuelos", b =>
                {
                    b.Property<int>("VuelosID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aerolinea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cinty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fecha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VuelosID");

                    b.ToTable("Vuelos");
                });

            modelBuilder.Entity("aereolinia.Models.Empleado", b =>
                {
                    b.HasOne("aereolinia.Models.TypeEmpleado", "TypeEmpleado")
                        .WithMany("Empleado")
                        .HasForeignKey("TypeEmpleadoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
