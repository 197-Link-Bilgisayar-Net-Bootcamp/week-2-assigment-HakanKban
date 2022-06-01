﻿// <auto-generated />
using System;
using HakanKabanOdevWeek2.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HakanKabanOdevWeek2.Repository.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HakanKabanOdevWeek2.Core.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Sport"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Fight"
                        });
                });

            modelBuilder.Entity("HakanKabanOdevWeek2.Core.Model.Games", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("DownloadCounts")
                        .HasColumnType("int");

                    b.Property<string>("GamesName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            DownloadCounts = 3000,
                            GamesName = "Pes2022"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            DownloadCounts = 4000,
                            GamesName = "Fifa2022"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            DownloadCounts = 3200,
                            GamesName = "Tekken8"
                        });
                });

            modelBuilder.Entity("HakanKabanOdevWeek2.Core.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CountGame")
                        .HasColumnType("int");

                    b.Property<DateTime>("MembershipDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountGame = 24,
                            MembershipDate = new DateTime(2022, 6, 1, 14, 15, 51, 766, DateTimeKind.Local).AddTicks(368),
                            UserName = "Hakan"
                        },
                        new
                        {
                            Id = 2,
                            CountGame = 34,
                            MembershipDate = new DateTime(2022, 6, 1, 14, 15, 51, 766, DateTimeKind.Local).AddTicks(379),
                            UserName = "Hakan2"
                        });
                });

            modelBuilder.Entity("HakanKabanOdevWeek2.Core.Model.UserGames", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("GamesId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "GamesId");

                    b.HasIndex("GamesId");

                    b.ToTable("UserGames");
                });

            modelBuilder.Entity("HakanKabanOdevWeek2.Core.Model.Games", b =>
                {
                    b.HasOne("HakanKabanOdevWeek2.Core.Model.Category", "Category")
                        .WithMany("Games")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("HakanKabanOdevWeek2.Core.Model.UserGames", b =>
                {
                    b.HasOne("HakanKabanOdevWeek2.Core.Model.User", "User")
                        .WithMany("UserGames")
                        .HasForeignKey("GamesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HakanKabanOdevWeek2.Core.Model.Games", "Games")
                        .WithMany("UserGames")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Games");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HakanKabanOdevWeek2.Core.Model.Category", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("HakanKabanOdevWeek2.Core.Model.Games", b =>
                {
                    b.Navigation("UserGames");
                });

            modelBuilder.Entity("HakanKabanOdevWeek2.Core.Model.User", b =>
                {
                    b.Navigation("UserGames");
                });
#pragma warning restore 612, 618
        }
    }
}
