﻿// <auto-generated />
using Dreamlines.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dreamlines.DAL.Migrations
{
    [DbContext(typeof(SalesUnitngContext))]
    partial class SalesUnitngContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("Dreamlines.DAL.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BookingDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ShipId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ShipId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Dreamlines.DAL.SalesUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<string>("Currency")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("SalesUnits");
                });

            modelBuilder.Entity("Dreamlines.DAL.Ship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("SalesUnitId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SalesUnitId");

                    b.ToTable("Ships");
                });

            modelBuilder.Entity("Dreamlines.DAL.Booking", b =>
                {
                    b.HasOne("Dreamlines.DAL.Ship", null)
                        .WithMany("Bookings")
                        .HasForeignKey("ShipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Dreamlines.DAL.Ship", b =>
                {
                    b.HasOne("Dreamlines.DAL.SalesUnit", null)
                        .WithMany("Ships")
                        .HasForeignKey("SalesUnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
