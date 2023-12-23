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
    [Migration("20231223222149_InitialMigration")]
    partial class InitialMigration
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

                    b.Property<decimal>("Rating")
                        .HasColumnType("numeric");

                    b.Property<string>("TelegramUrl")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Assets");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Address = "Chilanzar 10 Kv",
                            CompanyWebUrl = "http://yoshtadbirkor.uz/innoplatforma",
                            CreatedAt = new DateTime(2023, 12, 23, 22, 21, 48, 571, DateTimeKind.Utc).AddTicks(4297),
                            Email = "company1@gmail.com",
                            FacebookUrl = "http://yoshtadbirkor.uz/innoplatforma",
                            InstagramUrl = "http://yoshtadbirkor.uz/innoplatforma",
                            Logo = "07f5477c-7b1f-432d-975c-dfdb48bda466_Screenshot 2023-03-03 181803.png",
                            Phone = "1234567890",
                            Rating = 5m,
                            TelegramUrl = "http://yoshtadbirkor.uz/innoplatforma"
                        },
                        new
                        {
                            Id = 2L,
                            Address = "Chilanzar 11 Kv",
                            CompanyWebUrl = "http://yoshtadbirkor.uz/innoplatforma",
                            CreatedAt = new DateTime(2023, 12, 23, 22, 21, 48, 571, DateTimeKind.Utc).AddTicks(4301),
                            Email = "company2@gmail.com",
                            FacebookUrl = "http://yoshtadbirkor.uz/innoplatforma",
                            InstagramUrl = "http://yoshtadbirkor.uz/innoplatforma",
                            Logo = "07f5477c-7b1f-432d-975c-dfdb48bda466_Screenshot 2023-03-03 181803.png",
                            Phone = "+998741231567",
                            Rating = 3m,
                            TelegramUrl = "http://yoshtadbirkor.uz/innoplatforma"
                        },
                        new
                        {
                            Id = 3L,
                            Address = "Sergeli 10 Kv",
                            CompanyWebUrl = "http://yoshtadbirkor.uz/innoplatforma",
                            CreatedAt = new DateTime(2023, 12, 23, 22, 21, 48, 571, DateTimeKind.Utc).AddTicks(4304),
                            Email = "company3@gmail.com",
                            FacebookUrl = "http://yoshtadbirkor.uz/innoplatforma",
                            InstagramUrl = "http://yoshtadbirkor.uz/innoplatforma",
                            Logo = "07f5477c-7b1f-432d-975c-dfdb48bda466_Screenshot 2023-03-03 181803.png",
                            Phone = "+998741234867",
                            Rating = 5m,
                            TelegramUrl = "http://yoshtadbirkor.uz/innoplatforma"
                        },
                        new
                        {
                            Id = 4L,
                            Address = "Sebzor 5 Kv",
                            CompanyWebUrl = "http://yoshtadbirkor.uz/innoplatforma",
                            CreatedAt = new DateTime(2023, 12, 23, 22, 21, 48, 571, DateTimeKind.Utc).AddTicks(4307),
                            Email = "company4@gmail.com",
                            FacebookUrl = "http://yoshtadbirkor.uz/innoplatforma",
                            InstagramUrl = "http://yoshtadbirkor.uz/innoplatforma",
                            Logo = "07f5477c-7b1f-432d-975c-dfdb48bda466_Screenshot 2023-03-03 181803.png",
                            Phone = "+998741634567",
                            Rating = 4m,
                            TelegramUrl = "http://yoshtadbirkor.uz/innoplatforma"
                        },
                        new
                        {
                            Id = 5L,
                            Address = "Chilanzar 19 Kv",
                            CompanyWebUrl = "http://yoshtadbirkor.uz/innoplatforma",
                            CreatedAt = new DateTime(2023, 12, 23, 22, 21, 48, 571, DateTimeKind.Utc).AddTicks(4310),
                            Email = "company5@gmail.com",
                            FacebookUrl = "http://yoshtadbirkor.uz/innoplatforma",
                            InstagramUrl = "http://yoshtadbirkor.uz/innoplatforma",
                            Logo = "07f5477c-7b1f-432d-975c-dfdb48bda466_Screenshot 2023-03-03 181803.png",
                            Phone = "+998741232567",
                            Rating = 5m,
                            TelegramUrl = "http://yoshtadbirkor.uz/innoplatforma"
                        });
                });

            modelBuilder.Entity("Icarus.Domain.Entities.Category", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2023, 12, 23, 22, 21, 48, 571, DateTimeKind.Utc).AddTicks(4443),
                            Name = "Moliyalashtirish"
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2023, 12, 23, 22, 21, 48, 571, DateTimeKind.Utc).AddTicks(4444),
                            Name = "Konsultatsiya"
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2023, 12, 23, 22, 21, 48, 571, DateTimeKind.Utc).AddTicks(4446),
                            Name = "Iqtisodiyot"
                        },
                        new
                        {
                            Id = 4L,
                            CreatedAt = new DateTime(2023, 12, 23, 22, 21, 48, 571, DateTimeKind.Utc).AddTicks(4447),
                            Name = "Tijorat"
                        },
                        new
                        {
                            Id = 5L,
                            CreatedAt = new DateTime(2023, 12, 23, 22, 21, 48, 571, DateTimeKind.Utc).AddTicks(4448),
                            Name = "Biznes Ta'lim"
                        });
                });

            modelBuilder.Entity("Icarus.Domain.Entities.Department", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("AssetId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Latitude")
                        .HasColumnType("text");

                    b.Property<string>("Longitude")
                        .HasColumnType("text");

                    b.Property<decimal>("Rating")
                        .HasColumnType("numeric");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            AssetId = 1L,
                            CreatedAt = new DateTime(2023, 12, 23, 22, 21, 48, 571, DateTimeKind.Utc).AddTicks(4487),
                            Latitude = "41.279390",
                            Longitude = "69.197976",
                            Rating = 5m
                        },
                        new
                        {
                            Id = 2L,
                            AssetId = 2L,
                            CreatedAt = new DateTime(2023, 12, 23, 22, 21, 48, 571, DateTimeKind.Utc).AddTicks(4489),
                            Latitude = "40.7128",
                            Longitude = "-74.0060",
                            Rating = 5m
                        },
                        new
                        {
                            Id = 3L,
                            AssetId = 3L,
                            CreatedAt = new DateTime(2023, 12, 23, 22, 21, 48, 571, DateTimeKind.Utc).AddTicks(4491),
                            Latitude = "48.8566",
                            Longitude = "2.3522",
                            Rating = 4m
                        },
                        new
                        {
                            Id = 4L,
                            AssetId = 4L,
                            CreatedAt = new DateTime(2023, 12, 23, 22, 21, 48, 571, DateTimeKind.Utc).AddTicks(4493),
                            Latitude = "35.6895",
                            Longitude = "139.6917",
                            Rating = 4m
                        },
                        new
                        {
                            Id = 5L,
                            AssetId = 5L,
                            CreatedAt = new DateTime(2023, 12, 23, 22, 21, 48, 571, DateTimeKind.Utc).AddTicks(4495),
                            Latitude = "-33.8688",
                            Longitude = "151.2093",
                            Rating = 3m
                        });
                });

            modelBuilder.Entity("Icarus.Domain.Entities.DepartmentCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("CategoryId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("DepartmentId")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("DepartmentCategories");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CategoryId = 2L,
                            CreatedAt = new DateTime(2023, 12, 23, 22, 21, 48, 571, DateTimeKind.Utc).AddTicks(4531),
                            DepartmentId = 5L,
                            Description = "Assalomu Alaykum !"
                        },
                        new
                        {
                            Id = 2L,
                            CategoryId = 3L,
                            CreatedAt = new DateTime(2023, 12, 23, 22, 21, 48, 571, DateTimeKind.Utc).AddTicks(4533),
                            DepartmentId = 1L,
                            Description = "Assalomu Alaykum !"
                        },
                        new
                        {
                            Id = 3L,
                            CategoryId = 4L,
                            CreatedAt = new DateTime(2023, 12, 23, 22, 21, 48, 571, DateTimeKind.Utc).AddTicks(4534),
                            DepartmentId = 4L,
                            Description = "Assalomu Alaykum !"
                        },
                        new
                        {
                            Id = 4L,
                            CategoryId = 5L,
                            CreatedAt = new DateTime(2023, 12, 23, 22, 21, 48, 571, DateTimeKind.Utc).AddTicks(4536),
                            DepartmentId = 3L,
                            Description = "Assalomu Alaykum !"
                        },
                        new
                        {
                            Id = 5L,
                            CategoryId = 1L,
                            CreatedAt = new DateTime(2023, 12, 23, 22, 21, 48, 571, DateTimeKind.Utc).AddTicks(4538),
                            DepartmentId = 2L,
                            Description = "Assalomu Alaykum !"
                        });
                });

            modelBuilder.Entity("Icarus.Domain.Entities.DepartmentResponse", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("DepartmentId")
                        .HasColumnType("bigint");

                    b.Property<long>("RequestId")
                        .HasColumnType("bigint");

                    b.Property<string>("ResponseBody")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("RequestId");

                    b.ToTable("DepartmentResponses");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2023, 12, 23, 22, 21, 48, 571, DateTimeKind.Utc).AddTicks(4577),
                            DepartmentId = 1L,
                            RequestId = 1L,
                            ResponseBody = "Moliya"
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2023, 12, 23, 22, 21, 48, 571, DateTimeKind.Utc).AddTicks(4579),
                            DepartmentId = 3L,
                            RequestId = 2L,
                            ResponseBody = "Iqtisodiyot"
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2023, 12, 23, 22, 21, 48, 571, DateTimeKind.Utc).AddTicks(4581),
                            DepartmentId = 2L,
                            RequestId = 3L,
                            ResponseBody = "Biznes Ta'lim"
                        },
                        new
                        {
                            Id = 4L,
                            CreatedAt = new DateTime(2023, 12, 23, 22, 21, 48, 571, DateTimeKind.Utc).AddTicks(4583),
                            DepartmentId = 5L,
                            RequestId = 4L,
                            ResponseBody = "Konsultatsiya"
                        },
                        new
                        {
                            Id = 5L,
                            CreatedAt = new DateTime(2023, 12, 23, 22, 21, 48, 571, DateTimeKind.Utc).AddTicks(4584),
                            DepartmentId = 4L,
                            RequestId = 5L,
                            ResponseBody = "Ijtimoiy Himoya"
                        });
                });

            modelBuilder.Entity("Icarus.Domain.Entities.Request", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("DepartmentId")
                        .HasColumnType("bigint");

                    b.Property<string>("RequestBody")
                        .HasColumnType("text");

                    b.Property<string>("RequestTitle")
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("UserId");

                    b.ToTable("Requests");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2023, 12, 23, 22, 21, 48, 571, DateTimeKind.Utc).AddTicks(4353),
                            DepartmentId = 1L,
                            RequestBody = "Moliya",
                            RequestTitle = "I have best idea for these project ALATOR",
                            Status = 0,
                            UserId = 2L
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2023, 12, 23, 22, 21, 48, 571, DateTimeKind.Utc).AddTicks(4355),
                            DepartmentId = 3L,
                            RequestBody = "Iqtisodiyot",
                            RequestTitle = "I have best idea for these project ALATOR",
                            Status = 0,
                            UserId = 1L
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2023, 12, 23, 22, 21, 48, 571, DateTimeKind.Utc).AddTicks(4357),
                            DepartmentId = 2L,
                            RequestBody = "Biznes Ta'lim",
                            RequestTitle = "i hope to study at Haad Lc",
                            Status = 0,
                            UserId = 5L
                        },
                        new
                        {
                            Id = 4L,
                            CreatedAt = new DateTime(2023, 12, 23, 22, 21, 48, 571, DateTimeKind.Utc).AddTicks(4359),
                            DepartmentId = 5L,
                            RequestBody = "Konsultatsiya",
                            RequestTitle = "I have best idea for these project ALATOR",
                            Status = 0,
                            UserId = 3L
                        },
                        new
                        {
                            Id = 5L,
                            CreatedAt = new DateTime(2023, 12, 23, 22, 21, 48, 571, DateTimeKind.Utc).AddTicks(4361),
                            DepartmentId = 4L,
                            RequestBody = "Ijtimoiy Himoya",
                            RequestTitle = "I have need a lot money",
                            Status = 0,
                            UserId = 4L
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2023, 12, 23, 22, 21, 48, 571, DateTimeKind.Utc).AddTicks(4038),
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            Image = "07f5477c-7b1f-432d-975c-dfdb48bda466_Screenshot 2023-03-03 181803.png",
                            LastName = "Doe",
                            Password = "john123456789",
                            Phone = "123456789",
                            Role = 0
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2023, 12, 23, 22, 21, 48, 571, DateTimeKind.Utc).AddTicks(4045),
                            Email = "jane.smith@example.com",
                            FirstName = "Jane",
                            Image = "07f5477c-7b1f-432d-975c-dfdb48bda466_Screenshot 2023-03-03 181803.png",
                            LastName = "Smith",
                            Password = "jane123456789",
                            Phone = "987654321",
                            Role = 0
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2023, 12, 23, 22, 21, 48, 571, DateTimeKind.Utc).AddTicks(4047),
                            Email = "michael.johnson@example.com",
                            FirstName = "Michael",
                            Image = "07f5477c-7b1f-432d-975c-dfdb48bda466_Screenshot 2023-03-03 181803.png",
                            LastName = "Johnson",
                            Password = "michael123456789",
                            Phone = "555555555",
                            Role = 0
                        },
                        new
                        {
                            Id = 4L,
                            CreatedAt = new DateTime(2023, 12, 23, 22, 21, 48, 571, DateTimeKind.Utc).AddTicks(4049),
                            Email = "emily.anderson@example.com",
                            FirstName = "Emily",
                            Image = "07f5477c-7b1f-432d-975c-dfdb48bda466_Screenshot 2023-03-03 181803.png",
                            LastName = "Anderson",
                            Password = "emily123456789",
                            Phone = "333333333",
                            Role = 0
                        },
                        new
                        {
                            Id = 5L,
                            CreatedAt = new DateTime(2023, 12, 23, 22, 21, 48, 571, DateTimeKind.Utc).AddTicks(4051),
                            Email = "william.taylor@example.com",
                            FirstName = "William",
                            Image = "07f5477c-7b1f-432d-975c-dfdb48bda466_Screenshot 2023-03-03 181803.png",
                            LastName = "Taylor",
                            Password = "william123456789",
                            Phone = "777777777",
                            Role = 0
                        });
                });

            modelBuilder.Entity("Icarus.Domain.Entities.Department", b =>
                {
                    b.HasOne("Icarus.Domain.Entities.Asset", "Asset")
                        .WithMany()
                        .HasForeignKey("AssetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asset");
                });

            modelBuilder.Entity("Icarus.Domain.Entities.DepartmentCategory", b =>
                {
                    b.HasOne("Icarus.Domain.Entities.Category", "Category")
                        .WithMany("DepartmentCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Icarus.Domain.Entities.Department", "Department")
                        .WithMany("DepartmentCategories")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Icarus.Domain.Entities.DepartmentResponse", b =>
                {
                    b.HasOne("Icarus.Domain.Entities.Department", "WhichDepartment")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Icarus.Domain.Entities.Request", "Request")
                        .WithMany("DepartmentResponses")
                        .HasForeignKey("RequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Request");

                    b.Navigation("WhichDepartment");
                });

            modelBuilder.Entity("Icarus.Domain.Entities.Request", b =>
                {
                    b.HasOne("Icarus.Domain.Entities.Department", "WhichDepartment")
                        .WithMany("Requests")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Icarus.Domain.Entities.User", "FromWho")
                        .WithMany("Requests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FromWho");

                    b.Navigation("WhichDepartment");
                });

            modelBuilder.Entity("Icarus.Domain.Entities.Category", b =>
                {
                    b.Navigation("DepartmentCategories");
                });

            modelBuilder.Entity("Icarus.Domain.Entities.Department", b =>
                {
                    b.Navigation("DepartmentCategories");

                    b.Navigation("Requests");
                });

            modelBuilder.Entity("Icarus.Domain.Entities.Request", b =>
                {
                    b.Navigation("DepartmentResponses");
                });

            modelBuilder.Entity("Icarus.Domain.Entities.User", b =>
                {
                    b.Navigation("Requests");
                });
#pragma warning restore 612, 618
        }
    }
}