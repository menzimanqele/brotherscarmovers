﻿// <auto-generated />
using System;
using BrothersCarMovers.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BrothersCarMovers.Data.Migrations
{
    [DbContext(typeof(BrothersCarMoversDataContext))]
    [Migration("20220616090850_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BrothersCarMovers.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ImageID")
                        .HasColumnType("int");

                    b.Property<bool?>("IsCurrent")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsNew")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsSynced")
                        .HasColumnType("bit");

                    b.Property<int>("JobTitleId")
                        .HasColumnType("int");

                    b.Property<Guid?>("LastSyncClient")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastSyncDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("JobTitleId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("BrothersCarMovers.Entities.JobTitle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsCurrent")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsNew")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsSynced")
                        .HasColumnType("bit");

                    b.Property<Guid?>("LastSyncClient")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastSyncDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JobTitles");
                });

            modelBuilder.Entity("BrothersCarMovers.Entities.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsCurrent")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsNew")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsSynced")
                        .HasColumnType("bit");

                    b.Property<Guid?>("LastSyncClient")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastSyncDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Licence")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MakeID")
                        .HasColumnType("int");

                    b.Property<int>("ModelId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("BrothersCarMovers.Entities.VehicleManufacture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsCurrent")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsNew")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsSynced")
                        .HasColumnType("bit");

                    b.Property<Guid?>("LastSyncClient")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastSyncDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehicleModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("VehicleManufactures");
                });

            modelBuilder.Entity("BrothersCarMovers.Entities.VehicleModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsCurrent")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsNew")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsSynced")
                        .HasColumnType("bit");

                    b.Property<Guid?>("LastSyncClient")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastSyncDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ManufactureId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VehicleManufactureId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VehicleManufactureId");

                    b.ToTable("VehicleModels");
                });

            modelBuilder.Entity("BrothersCarMovers.Entities.Employee", b =>
                {
                    b.HasOne("BrothersCarMovers.Entities.JobTitle", "JobTitle")
                        .WithMany("Employee")
                        .HasForeignKey("JobTitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JobTitle");
                });

            modelBuilder.Entity("BrothersCarMovers.Entities.VehicleModel", b =>
                {
                    b.HasOne("BrothersCarMovers.Entities.VehicleManufacture", "VehicleManufacture")
                        .WithMany("VehicleModel")
                        .HasForeignKey("VehicleManufactureId");

                    b.Navigation("VehicleManufacture");
                });

            modelBuilder.Entity("BrothersCarMovers.Entities.JobTitle", b =>
                {
                    b.Navigation("Employee");
                });

            modelBuilder.Entity("BrothersCarMovers.Entities.VehicleManufacture", b =>
                {
                    b.Navigation("VehicleModel");
                });
#pragma warning restore 612, 618
        }
    }
}
