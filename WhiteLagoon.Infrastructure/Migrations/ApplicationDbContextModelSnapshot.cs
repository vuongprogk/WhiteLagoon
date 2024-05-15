﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WhiteLagoon.Infrastructure.Data;

#nullable disable

namespace WhiteLagoon.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WhiteLagoon.Domain.Entities.Amenity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("VillaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VillaId");

                    b.ToTable("Amenities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Private Pool",
                            VillaId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Microwave",
                            VillaId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Private Balcony",
                            VillaId = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "1 king bed and 1 sofa bed",
                            VillaId = 1
                        },
                        new
                        {
                            Id = 5,
                            Name = "Private Plunge Pool",
                            VillaId = 2
                        },
                        new
                        {
                            Id = 6,
                            Name = "Microwave and Mini Refrigerator",
                            VillaId = 2
                        },
                        new
                        {
                            Id = 7,
                            Name = "Private Balcony",
                            VillaId = 2
                        },
                        new
                        {
                            Id = 8,
                            Name = "king bed or 2 double beds",
                            VillaId = 2
                        },
                        new
                        {
                            Id = 9,
                            Name = "Private Pool",
                            VillaId = 3
                        },
                        new
                        {
                            Id = 10,
                            Name = "Jacuzzi",
                            VillaId = 3
                        },
                        new
                        {
                            Id = 11,
                            Name = "Private Balcony",
                            VillaId = 3
                        });
                });

            modelBuilder.Entity("WhiteLagoon.Domain.Entities.Member", b =>
                {
                    b.Property<string>("MSSV")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MSSV");

                    b.ToTable("Members");

                    b.HasData(
                        new
                        {
                            MSSV = "DH52112120",
                            Email = "dh52112120@student.stu.edu.vn",
                            Name = "Trần Đức Vượng"
                        },
                        new
                        {
                            MSSV = "DH52113526",
                            Email = "DH52113526@student.stu.edu.vn",
                            Name = "Trần Thái Duy"
                        },
                        new
                        {
                            MSSV = "DH52110733",
                            Email = "DH52110733@student.stu.edu.vn",
                            Name = "Nguyễn Sơn Dương"
                        },
                        new
                        {
                            MSSV = "DH52110812",
                            Email = "DH52110812@student.stu.edu.vn",
                            Name = "Trương Thanh Đông"
                        },
                        new
                        {
                            MSSV = "DH52111142",
                            Email = "DH52113526@student.stu.edu.vn",
                            Name = "Nguyễn Huỳnh Thanh Khoa"
                        });
                });

            modelBuilder.Entity("WhiteLagoon.Domain.Entities.Villa", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateCreate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double?>("Price")
                        .HasColumnType("double");

                    b.Property<int>("Sqm")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            ImageUrl = "https://placehold.co/600x400",
                            Name = "Royal Villa",
                            Occupancy = 4,
                            Price = 200.0,
                            Sqm = 550
                        },
                        new
                        {
                            ID = 2,
                            Description = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            ImageUrl = "https://placehold.co/600x401",
                            Name = "Premium Pool Villa",
                            Occupancy = 4,
                            Price = 300.0,
                            Sqm = 550
                        },
                        new
                        {
                            ID = 3,
                            Description = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            ImageUrl = "https://placehold.co/600x402",
                            Name = "Luxury Pool Villa",
                            Occupancy = 4,
                            Price = 400.0,
                            Sqm = 750
                        });
                });

            modelBuilder.Entity("WhiteLagoon.Domain.Entities.VillaNumber", b =>
                {
                    b.Property<int>("Villa_Number")
                        .HasColumnType("int");

                    b.Property<string>("SpecialDetails")
                        .HasColumnType("longtext");

                    b.Property<int>("VillaId")
                        .HasColumnType("int");

                    b.HasKey("Villa_Number");

                    b.HasIndex("VillaId");

                    b.ToTable("VillaNumbers");

                    b.HasData(
                        new
                        {
                            Villa_Number = 101,
                            VillaId = 1
                        },
                        new
                        {
                            Villa_Number = 102,
                            VillaId = 1
                        },
                        new
                        {
                            Villa_Number = 201,
                            VillaId = 2
                        },
                        new
                        {
                            Villa_Number = 202,
                            VillaId = 2
                        },
                        new
                        {
                            Villa_Number = 301,
                            VillaId = 3
                        },
                        new
                        {
                            Villa_Number = 302,
                            VillaId = 3
                        });
                });

            modelBuilder.Entity("WhiteLagoon.Domain.Entities.Amenity", b =>
                {
                    b.HasOne("WhiteLagoon.Domain.Entities.Villa", "Villa")
                        .WithMany("VillaAmenity")
                        .HasForeignKey("VillaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Villa");
                });

            modelBuilder.Entity("WhiteLagoon.Domain.Entities.VillaNumber", b =>
                {
                    b.HasOne("WhiteLagoon.Domain.Entities.Villa", "Villa")
                        .WithMany()
                        .HasForeignKey("VillaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Villa");
                });

            modelBuilder.Entity("WhiteLagoon.Domain.Entities.Villa", b =>
                {
                    b.Navigation("VillaAmenity");
                });
#pragma warning restore 612, 618
        }
    }
}
