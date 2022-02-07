﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project1.Models;

namespace Project1.Migrations
{
    [DbContext(typeof(TasksContext))]
    [Migration("20220204223939_Inital")]
    partial class Inital
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Project1.Models.CategoryModel", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "School"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Work"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Home"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Church"
                        });
                });

            modelBuilder.Entity("Project1.Models.TasksModel", b =>
                {
                    b.Property<int>("TaskID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Completed")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quadrant")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Task")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TaskID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            TaskID = 1,
                            CategoryID = 1,
                            Completed = true,
                            Date = new DateTime(2022, 2, 4, 22, 39, 38, 855, DateTimeKind.Utc).AddTicks(3080),
                            Quadrant = 1,
                            Task = "Make the database"
                        },
                        new
                        {
                            TaskID = 2,
                            CategoryID = 3,
                            Completed = false,
                            Date = new DateTime(2022, 2, 4, 22, 39, 38, 855, DateTimeKind.Utc).AddTicks(4220),
                            Quadrant = 2,
                            Task = "Make the Shared Layout"
                        },
                        new
                        {
                            TaskID = 3,
                            CategoryID = 4,
                            Completed = false,
                            Date = new DateTime(2022, 2, 4, 22, 39, 38, 855, DateTimeKind.Utc).AddTicks(4250),
                            Quadrant = 3,
                            Task = "Make the quadrant views"
                        },
                        new
                        {
                            TaskID = 4,
                            CategoryID = 2,
                            Completed = false,
                            Date = new DateTime(2022, 2, 4, 22, 39, 38, 855, DateTimeKind.Utc).AddTicks(4250),
                            Quadrant = 4,
                            Task = "Make the Controllers"
                        });
                });

            modelBuilder.Entity("Project1.Models.TasksModel", b =>
                {
                    b.HasOne("Project1.Models.CategoryModel", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
