﻿// <auto-generated />
using FilmRater.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FilmRater.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200802194606_pleasework")]
    partial class pleasework
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity("FilmRater.Core.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DirectorName");

                    b.Property<int>("Duration");

                    b.Property<string>("Genres");

                    b.Property<string>("Rating");

                    b.Property<string>("Title");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("FilmRater.Core.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("userName");

                    b.HasKey("id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FilmRater.Core.Models.Movie", b =>
                {
                    b.HasOne("FilmRater.Core.Models.User", "User")
                        .WithMany("Movies")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
