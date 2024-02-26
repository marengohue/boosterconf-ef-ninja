﻿// <auto-generated />
using System;
using BoosterConf.Ef.Ninja.TaskB.Solved.Storage.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BoosterConf.Ef.Ninja.TaskB.Solved.Migrations
{
    [DbContext(typeof(InsuranceDbContext))]
    partial class InsuranceDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BoosterConf.Ef.Ninja.TaskB.Solved.Storage.Entities.Audit.AuditClaimEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("Changed")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("ClaimId")
                        .HasColumnType("int");

                    b.Property<string>("WhatHappenedHere")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("ClaimId");

                    b.ToTable("Claim", "audit");
                });

            modelBuilder.Entity("BoosterConf.Ef.Ninja.TaskB.Solved.Storage.Entities.Audit.AuditCoverEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("Changed")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("CoverId")
                        .HasColumnType("int");

                    b.Property<string>("WhatHappenedHere")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("CoverId");

                    b.ToTable("Cover", "audit");
                });

            modelBuilder.Entity("BoosterConf.Ef.Ninja.TaskB.Solved.Storage.Entities.ClaimEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasPrecision(14, 4)
                        .HasColumnType("decimal(14,4)");

                    b.Property<int>("CoverId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("Date")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<Guid>("ExternalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CoverId");

                    b.HasIndex("StatusId");

                    b.ToTable("Claims");
                });

            modelBuilder.Entity("BoosterConf.Ef.Ninja.TaskB.Solved.Storage.Entities.ClaimStatusEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<Guid>("ExternalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("ClaimStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "The claim has been submitted and is awaiting review.",
                            ExternalId = new Guid("659a9701-1f76-4993-bcbd-4d703c4e91cf"),
                            Name = "Submitted"
                        },
                        new
                        {
                            Id = 2,
                            Description = "The claim is currently being reviewed by an insurance adjuster.",
                            ExternalId = new Guid("5e5fb9bb-2f4a-4a6d-a8ff-3cd43321d7a3"),
                            Name = "In Review"
                        },
                        new
                        {
                            Id = 3,
                            Description = "The claim has been approved for payment.",
                            ExternalId = new Guid("5ee54db2-1d57-4b82-89cd-ece3957cf1b3"),
                            Name = "Approved"
                        },
                        new
                        {
                            Id = 4,
                            Description = "The claim has been rejected and will not be paid.",
                            ExternalId = new Guid("9fad7c66-4554-4e26-858b-029f23964d61"),
                            Name = "Rejected"
                        },
                        new
                        {
                            Id = 5,
                            Description = "The claim has been paid to the policyholder.",
                            ExternalId = new Guid("6dcd8442-3463-4ff5-afa9-66aa54191c28"),
                            Name = "Paid"
                        });
                });

            modelBuilder.Entity("BoosterConf.Ef.Ninja.TaskB.Solved.Storage.Entities.CoverEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CoverTypeId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("EndDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("ExternalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Premium")
                        .HasPrecision(14, 4)
                        .HasColumnType("decimal(14,4)");

                    b.Property<DateTimeOffset>("StartDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("CoverTypeId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Covers");
                });

            modelBuilder.Entity("BoosterConf.Ef.Ninja.TaskB.Solved.Storage.Entities.CoverTypeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<Guid>("ExternalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("CoverTypes");
                });

            modelBuilder.Entity("BoosterConf.Ef.Ninja.TaskB.Solved.Storage.Entities.CustomerAddressEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("ExternalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("CustomerAddresses");
                });

            modelBuilder.Entity("BoosterConf.Ef.Ninja.TaskB.Solved.Storage.Entities.CustomerEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("ExternalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BoosterConf.Ef.Ninja.TaskB.Solved.Storage.Entities.Audit.AuditClaimEntity", b =>
                {
                    b.HasOne("BoosterConf.Ef.Ninja.TaskB.Solved.Storage.Entities.ClaimEntity", "Claim")
                        .WithMany()
                        .HasForeignKey("ClaimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Claim");
                });

            modelBuilder.Entity("BoosterConf.Ef.Ninja.TaskB.Solved.Storage.Entities.Audit.AuditCoverEntity", b =>
                {
                    b.HasOne("BoosterConf.Ef.Ninja.TaskB.Solved.Storage.Entities.CoverEntity", "Cover")
                        .WithMany()
                        .HasForeignKey("CoverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cover");
                });

            modelBuilder.Entity("BoosterConf.Ef.Ninja.TaskB.Solved.Storage.Entities.ClaimEntity", b =>
                {
                    b.HasOne("BoosterConf.Ef.Ninja.TaskB.Solved.Storage.Entities.CoverEntity", "Cover")
                        .WithMany("Claims")
                        .HasForeignKey("CoverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BoosterConf.Ef.Ninja.TaskB.Solved.Storage.Entities.ClaimStatusEntity", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cover");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("BoosterConf.Ef.Ninja.TaskB.Solved.Storage.Entities.CoverEntity", b =>
                {
                    b.HasOne("BoosterConf.Ef.Ninja.TaskB.Solved.Storage.Entities.CoverTypeEntity", "CoverType")
                        .WithMany()
                        .HasForeignKey("CoverTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BoosterConf.Ef.Ninja.TaskB.Solved.Storage.Entities.CustomerEntity", "Customer")
                        .WithMany("Covers")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CoverType");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("BoosterConf.Ef.Ninja.TaskB.Solved.Storage.Entities.CustomerEntity", b =>
                {
                    b.HasOne("BoosterConf.Ef.Ninja.TaskB.Solved.Storage.Entities.CustomerAddressEntity", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("BoosterConf.Ef.Ninja.TaskB.Solved.Storage.Entities.CoverEntity", b =>
                {
                    b.Navigation("Claims");
                });

            modelBuilder.Entity("BoosterConf.Ef.Ninja.TaskB.Solved.Storage.Entities.CustomerEntity", b =>
                {
                    b.Navigation("Covers");
                });
#pragma warning restore 612, 618
        }
    }
}
