﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission_08_group_1_1.Models;

namespace Mission_08_group_1_1.Migrations
{
    [DbContext(typeof(TaskContext))]
    partial class TaskContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission_08_group_1_1.Models.Category", b =>
                {
                    b.Property<int>("CatergoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CatergoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CatergoryId");

                    b.ToTable("Catergories");

                    b.HasData(
                        new
                        {
                            CatergoryId = 1,
                            CatergoryName = "Home"
                        },
                        new
                        {
                            CatergoryId = 2,
                            CatergoryName = "School"
                        },
                        new
                        {
                            CatergoryId = 3,
                            CatergoryName = "Work"
                        },
                        new
                        {
                            CatergoryId = 4,
                            CatergoryName = "Church"
                        });
                });

            modelBuilder.Entity("Mission_08_group_1_1.Models.Tasks", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Completed")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quadrant")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Task")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TaskId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            TaskId = 1,
                            CategoryId = 1,
                            Completed = false,
                            DueDate = new DateTime(2023, 2, 23, 15, 1, 25, 714, DateTimeKind.Local).AddTicks(7189),
                            Quadrant = 1,
                            Task = "Crisis"
                        },
                        new
                        {
                            TaskId = 2,
                            CategoryId = 1,
                            Completed = false,
                            DueDate = new DateTime(2023, 2, 23, 15, 1, 25, 718, DateTimeKind.Local).AddTicks(5316),
                            Quadrant = 2,
                            Task = "Recreation"
                        },
                        new
                        {
                            TaskId = 3,
                            CategoryId = 3,
                            Completed = false,
                            DueDate = new DateTime(2023, 2, 23, 15, 1, 25, 718, DateTimeKind.Local).AddTicks(5412),
                            Quadrant = 3,
                            Task = "Interruptions"
                        },
                        new
                        {
                            TaskId = 4,
                            CategoryId = 3,
                            Completed = false,
                            DueDate = new DateTime(2023, 2, 23, 15, 1, 25, 718, DateTimeKind.Local).AddTicks(5420),
                            Quadrant = 4,
                            Task = "Time Wasters"
                        });
                });

            modelBuilder.Entity("Mission_08_group_1_1.Models.Tasks", b =>
                {
                    b.HasOne("Mission_08_group_1_1.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
