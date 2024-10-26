﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PiecesOfArt;

#nullable disable

namespace PiecesOfArt.Migrations
{
    [DbContext(typeof(ApppDbContext))]
    [Migration("20241026110555_s")]
    partial class s
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-rc.2.24474.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PieceOfArt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("PiecesOfArt");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Price = 100000m,
                            PublicationDate = new DateTime(2024, 10, 26, 14, 5, 54, 125, DateTimeKind.Local).AddTicks(4526),
                            Title = "Starry Night"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Price = 500000m,
                            PublicationDate = new DateTime(2024, 10, 26, 14, 5, 54, 127, DateTimeKind.Local).AddTicks(6871),
                            Title = "The Mona Lisa"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Price = 120000m,
                            PublicationDate = new DateTime(2024, 10, 26, 14, 5, 54, 127, DateTimeKind.Local).AddTicks(6898),
                            Title = "Composition VIII"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 4,
                            Price = 200000m,
                            PublicationDate = new DateTime(2024, 10, 26, 14, 5, 54, 127, DateTimeKind.Local).AddTicks(6903),
                            Title = "The Persistence of Memory"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 5,
                            Price = 150000m,
                            PublicationDate = new DateTime(2024, 10, 26, 14, 5, 54, 127, DateTimeKind.Local).AddTicks(6905),
                            Title = "Small Pyramid"
                        });
                });

            modelBuilder.Entity("PiecesOfArt.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A 19th-century art movement characterized by small, thin brush strokes and emphasis on light and movement.",
                            Name = "Impressionism"
                        },
                        new
                        {
                            Id = 2,
                            Description = "A period in European history marking the revival of classical learning and wisdom.",
                            Name = "Renaissance"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Art that uses shapes, colors, forms, and gestural marks to achieve its effect rather than depicting objects.",
                            Name = "Abstract"
                        },
                        new
                        {
                            Id = 4,
                            Description = "A broad category that reflects artistic work produced during the late 19th to mid-20th century.",
                            Name = "Modern"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Art from ancient civilizations, including Egyptian, Mesopotamian, and classical Greek.",
                            Name = "Ancient"
                        });
                });

            modelBuilder.Entity("PiecesOfArt.Models.LoyaltyCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LoyaltyCards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "10% Off",
                            Name = "Bronze"
                        },
                        new
                        {
                            Id = 2,
                            Description = "20% Off",
                            Name = "Silver"
                        },
                        new
                        {
                            Id = 3,
                            Description = "30% Off",
                            Name = "Gold"
                        },
                        new
                        {
                            Id = 4,
                            Description = "40% Off",
                            Name = "Platinum"
                        },
                        new
                        {
                            Id = 5,
                            Description = "50% Off",
                            Name = "Crystal"
                        });
                });

            modelBuilder.Entity("PiecesOfArt.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LoyaltyCardId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LoyaltyCardId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 30,
                            Email = "user1@example.com",
                            LoyaltyCardId = 1,
                            Name = "User1"
                        },
                        new
                        {
                            Id = 2,
                            Age = 25,
                            Email = "user2@example.com",
                            LoyaltyCardId = 2,
                            Name = "User2"
                        },
                        new
                        {
                            Id = 3,
                            Age = 28,
                            Email = "user3@example.com",
                            LoyaltyCardId = 3,
                            Name = "User3"
                        },
                        new
                        {
                            Id = 4,
                            Age = 22,
                            Email = "user4@example.com",
                            LoyaltyCardId = 4,
                            Name = "User4"
                        },
                        new
                        {
                            Id = 5,
                            Age = 26,
                            Email = "user5@example.com",
                            LoyaltyCardId = 5,
                            Name = "User5"
                        });
                });

            modelBuilder.Entity("PieceOfArt", b =>
                {
                    b.HasOne("PiecesOfArt.Models.Category", "Category")
                        .WithMany("PiecesOfArt")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PiecesOfArt.Models.User", null)
                        .WithMany("PiecesOfArt")
                        .HasForeignKey("UserId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("PiecesOfArt.Models.User", b =>
                {
                    b.HasOne("PiecesOfArt.Models.LoyaltyCard", "LoyaltyCard")
                        .WithMany("Users")
                        .HasForeignKey("LoyaltyCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoyaltyCard");
                });

            modelBuilder.Entity("PiecesOfArt.Models.Category", b =>
                {
                    b.Navigation("PiecesOfArt");
                });

            modelBuilder.Entity("PiecesOfArt.Models.LoyaltyCard", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("PiecesOfArt.Models.User", b =>
                {
                    b.Navigation("PiecesOfArt");
                });
#pragma warning restore 612, 618
        }
    }
}
