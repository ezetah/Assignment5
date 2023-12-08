﻿// <auto-generated />
using Assignment5.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assignment5.Migrations
{
    [DbContext(typeof(Assignment5Context))]
    [Migration("20231208032437_dbupdate2")]
    partial class dbupdate2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Assignment5.Models.Artist", b =>
                {
                    b.Property<int>("artistID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("artistID"));

                    b.Property<string>("artistTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("genreID")
                        .HasColumnType("int");

                    b.HasKey("artistID");

                    b.ToTable("Artist");
                });

            modelBuilder.Entity("Assignment5.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("genreTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("Assignment5.Models.ShoppingCart", b =>
                {
                    b.Property<int>("shoppingCartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("shoppingCartID"));

                    b.Property<int>("songID")
                        .HasColumnType("int");

                    b.Property<int>("userID")
                        .HasColumnType("int");

                    b.HasKey("shoppingCartID");

                    b.ToTable("ShoppingCart");
                });

            modelBuilder.Entity("Assignment5.Models.Song", b =>
                {
                    b.Property<int>("songID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("songID"));

                    b.Property<int>("artistID")
                        .HasColumnType("int");

                    b.Property<string>("artistTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("genreID")
                        .HasColumnType("int");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("songTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("songID");

                    b.HasIndex("genreID");

                    b.ToTable("Song");
                });

            modelBuilder.Entity("Assignment5.Models.User", b =>
                {
                    b.Property<int>("userID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("userID"));

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Assignment5.Models.Song", b =>
                {
                    b.HasOne("Assignment5.Models.Genre", "Genre")
                        .WithMany("songs")
                        .HasForeignKey("genreID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Assignment5.Models.Genre", b =>
                {
                    b.Navigation("songs");
                });
#pragma warning restore 612, 618
        }
    }
}