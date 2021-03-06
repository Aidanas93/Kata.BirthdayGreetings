﻿// <auto-generated />
using System;
using Kata.BirthdayGreetings.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Kata.BirthdayGreetings.Data.Migrations
{
    [DbContext(typeof(SQLiteDbContext))]
    [Migration("20200811092310_addedSeeding")]
    partial class addedSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6");

            modelBuilder.Entity("Kata.BirthdayGreetings.Data.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Person");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(1999, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "valuckas.mantas@gmail.com",
                            FirstName = "Mantas",
                            LastName = "Valuckas",
                            PhoneNumber = "865741254"
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(1999, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "rutenis@gmail.com",
                            FirstName = "Rutenis",
                            LastName = "Naugzemis",
                            PhoneNumber = "865741254"
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTime(1999, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "aidanas93@gmail.com",
                            FirstName = "Aidanas",
                            LastName = "Naugzemis",
                            PhoneNumber = "864741327"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
