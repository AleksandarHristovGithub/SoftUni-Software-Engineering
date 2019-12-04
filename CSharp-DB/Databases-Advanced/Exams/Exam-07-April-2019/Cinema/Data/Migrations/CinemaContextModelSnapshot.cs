﻿// <auto-generated />
using System;
using Cinema.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cinema.Data.Migrations
{
    [DbContext(typeof(CinemaContext))]
    partial class CinemaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cinema.Data.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<decimal>("Balance");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Cinema.Data.Models.Hall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Is3D");

                    b.Property<bool>("Is4Dx");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Halls");
                });

            modelBuilder.Entity("Cinema.Data.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<TimeSpan>("Duration");

                    b.Property<int>("Genre");

                    b.Property<double>("Rating");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Cinema.Data.Models.Projection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTime");

                    b.Property<int>("HallId");

                    b.Property<int>("MovieId");

                    b.HasKey("Id");

                    b.HasIndex("HallId");

                    b.HasIndex("MovieId");

                    b.ToTable("Projections");
                });

            modelBuilder.Entity("Cinema.Data.Models.Seat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HallId");

                    b.HasKey("Id");

                    b.HasIndex("HallId");

                    b.ToTable("Seats");
                });

            modelBuilder.Entity("Cinema.Data.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<decimal>("Price");

                    b.Property<int>("ProjectionId");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProjectionId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Cinema.Data.Models.Projection", b =>
                {
                    b.HasOne("Cinema.Data.Models.Hall", "Hall")
                        .WithMany("Projections")
                        .HasForeignKey("HallId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Cinema.Data.Models.Movie", "Movie")
                        .WithMany("Projections")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cinema.Data.Models.Seat", b =>
                {
                    b.HasOne("Cinema.Data.Models.Hall", "Hall")
                        .WithMany("Seats")
                        .HasForeignKey("HallId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cinema.Data.Models.Ticket", b =>
                {
                    b.HasOne("Cinema.Data.Models.Customer", "Customer")
                        .WithMany("Tickets")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Cinema.Data.Models.Projection", "Projection")
                        .WithMany("Tickets")
                        .HasForeignKey("ProjectionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
