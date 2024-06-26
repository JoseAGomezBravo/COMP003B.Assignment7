﻿// <auto-generated />
using System;
using COMP003B.Assignment7.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace COMP003B.Assignment7.Migrations
{
    [DbContext(typeof(WebActorMovieContext))]
    [Migration("20240511060536_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("COMP003B.Assignment7.Models.Actor", b =>
                {
                    b.Property<int>("ActorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ActorId"));

                    b.Property<string>("ActorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActorId");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("COMP003B.Assignment7.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieId"));

                    b.Property<string>("MovieName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("COMP003B.Assignment7.Models.MovieActor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ActorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ActorId1")
                        .HasColumnType("int");

                    b.Property<string>("MovieId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MovieId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActorId1");

                    b.HasIndex("MovieId1");

                    b.ToTable("MovieActors");
                });

            modelBuilder.Entity("COMP003B.Assignment7.Models.MovieActor", b =>
                {
                    b.HasOne("COMP003B.Assignment7.Models.Actor", "Actor")
                        .WithMany()
                        .HasForeignKey("ActorId1");

                    b.HasOne("COMP003B.Assignment7.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId1");

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });
#pragma warning restore 612, 618
        }
    }
}
