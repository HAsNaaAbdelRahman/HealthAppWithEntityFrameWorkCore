﻿// <auto-generated />
using System;
using CodeFirst;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeFirst.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CodeFirst.Models.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DailyId")
                        .HasColumnType("int");

                    b.Property<int>("WaterTake")
                        .HasColumnType("int");

                    b.Property<DateOnly>("date")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("DailyId");

                    b.ToTable("Activity");
                });

            modelBuilder.Entity("CodeFirst.Models.Authentication", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Email");

                    b.HasIndex("UserId");

                    b.ToTable("Authentication");
                });

            modelBuilder.Entity("CodeFirst.Models.Daily", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Daily");
                });

            modelBuilder.Entity("CodeFirst.Models.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ExerciseType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GoalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GoalId");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("CodeFirst.Models.Goal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("GoalType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Goals");
                });

            modelBuilder.Entity("CodeFirst.Models.Meal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("Calories")
                        .HasColumnType("real");

                    b.Property<int>("DailyId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("DateMeal")
                        .HasColumnType("date");

                    b.Property<string>("MealName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quentity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DailyId");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("CodeFirst.Models.Sleep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DailyId")
                        .HasColumnType("int");

                    b.Property<decimal>("Dueration")
                        .HasColumnType("decimal(18,2)");

                    b.Property<TimeOnly>("endHours")
                        .HasColumnType("time");

                    b.Property<TimeOnly>("startHours")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("DailyId")
                        .IsUnique();

                    b.ToTable("Sleep");
                });

            modelBuilder.Entity("CodeFirst.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CodeFirst.Models.UserHealth", b =>
                {
                    b.Property<decimal>("Height")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(18,2)");

                    b.HasIndex("UserId");

                    b.ToTable("UsersHealth");
                });

            modelBuilder.Entity("DailyUser", b =>
                {
                    b.Property<int>("DailiesId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("DailiesId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("DailyUser");
                });

            modelBuilder.Entity("CodeFirst.Models.Activity", b =>
                {
                    b.HasOne("CodeFirst.Models.Daily", "Daily")
                        .WithMany("Activity")
                        .HasForeignKey("DailyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Daily");
                });

            modelBuilder.Entity("CodeFirst.Models.Authentication", b =>
                {
                    b.HasOne("CodeFirst.Models.User", "User")
                        .WithMany("Authentications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CodeFirst.Models.Exercise", b =>
                {
                    b.HasOne("CodeFirst.Models.Goal", "goal")
                        .WithMany()
                        .HasForeignKey("GoalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("goal");
                });

            modelBuilder.Entity("CodeFirst.Models.Goal", b =>
                {
                    b.HasOne("CodeFirst.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CodeFirst.Models.Meal", b =>
                {
                    b.HasOne("CodeFirst.Models.Daily", "Daily")
                        .WithMany("Meal")
                        .HasForeignKey("DailyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Daily");
                });

            modelBuilder.Entity("CodeFirst.Models.Sleep", b =>
                {
                    b.HasOne("CodeFirst.Models.Daily", "Daily")
                        .WithOne("sleep")
                        .HasForeignKey("CodeFirst.Models.Sleep", "DailyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Daily");
                });

            modelBuilder.Entity("CodeFirst.Models.UserHealth", b =>
                {
                    b.HasOne("CodeFirst.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DailyUser", b =>
                {
                    b.HasOne("CodeFirst.Models.Daily", null)
                        .WithMany()
                        .HasForeignKey("DailiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirst.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CodeFirst.Models.Daily", b =>
                {
                    b.Navigation("Activity");

                    b.Navigation("Meal");

                    b.Navigation("sleep")
                        .IsRequired();
                });

            modelBuilder.Entity("CodeFirst.Models.User", b =>
                {
                    b.Navigation("Authentications");
                });
#pragma warning restore 612, 618
        }
    }
}
