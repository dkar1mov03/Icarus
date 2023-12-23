﻿// <auto-generated />
using System;
using Icarus.Data.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Icarus.Data.Migrations
{
    [DbContext(typeof(IcarusDbContext))]
    [Migration("20231223074221_DepartmentChanged")]
    partial class DepartmentChanged
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Icarus.Domain.Entities.Asset", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("CompanyWebUrl")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("character varying(13)");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FacebookUrl")
                        .HasColumnType("text");

                    b.Property<string>("InstagramUrl")
                        .HasColumnType("text");

                    b.Property<string>("Logo")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<string>("TelegramUrl")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Assets");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Asset");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Icarus.Domain.Entities.Category", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<short>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Icarus.Domain.Entities.DepartmentCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<long>("CategoryId")
                        .HasColumnType("bigint");

                    b.Property<short?>("CategoryId1")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("DepartmentId")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId1");

                    b.HasIndex("DepartmentId");

                    b.ToTable("DepartmentCategories");
                });

            modelBuilder.Entity("Icarus.Domain.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Icarus.Domain.Entities.Department", b =>
                {
                    b.HasBaseType("Icarus.Domain.Entities.Asset");

                    b.Property<string>("Latitude")
                        .HasColumnType("text");

                    b.Property<string>("Longitude")
                        .HasColumnType("text");

                    b.Property<decimal>("Rating")
                        .HasColumnType("numeric");

                    b.HasDiscriminator().HasValue("Department");
                });

            modelBuilder.Entity("Icarus.Domain.Entities.DepartmentCategory", b =>
                {
                    b.HasOne("Icarus.Domain.Entities.Category", "Category")
                        .WithMany("DepartmentCategories")
                        .HasForeignKey("CategoryId1");

                    b.HasOne("Icarus.Domain.Entities.Department", "Department")
                        .WithMany("DepartmentCategories")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Icarus.Domain.Entities.Category", b =>
                {
                    b.Navigation("DepartmentCategories");
                });

            modelBuilder.Entity("Icarus.Domain.Entities.Department", b =>
                {
                    b.Navigation("DepartmentCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
