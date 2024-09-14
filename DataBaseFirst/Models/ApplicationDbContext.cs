using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataBaseFirst.Models;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Activity> Activities { get; set; }

    public virtual DbSet<Authentication> Authentications { get; set; }

    public virtual DbSet<Daily> Dailies { get; set; }

    public virtual DbSet<Exercise> Exercises { get; set; }

    public virtual DbSet<Goal> Goals { get; set; }

    public virtual DbSet<Meal> Meals { get; set; }

    public virtual DbSet<Sleep> Sleeps { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserHealth> UserHealths { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=HASNAA-ABDELRAH;Database=HealthApp;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Activity>(entity =>
        {
            entity.HasKey(e => e.ActivityId).HasName("PK__Activity__45F4A791D0437D69");

            entity.ToTable("Activity");

            entity.Property(e => e.ActivityId).ValueGeneratedNever();
            entity.Property(e => e.Id).HasColumnName("ID");

            entity.HasOne(d => d.IdNavigation).WithMany(p => p.Activities)
                .HasForeignKey(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("DailyId_fk");
        });

        modelBuilder.Entity<Authentication>(entity =>
        {
            entity.HasKey(e => e.UserEmail).HasName("PK__Authenti__08638DF9B71C8146");

            entity.ToTable("Authentication");

            entity.Property(e => e.UserEmail)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.UserName)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.User).WithMany(p => p.Authentications)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("userId_Authentication_fk");
        });

        modelBuilder.Entity<Daily>(entity =>
        {
            entity.HasKey(e => e.DailyId).HasName("PK__Daily__650EC017ABC15015");

            entity.ToTable("Daily");

            entity.Property(e => e.DailyId).ValueGeneratedNever();
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.User).WithMany(p => p.Dailies)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("userIdDaily_fk");
        });

        modelBuilder.Entity<Exercise>(entity =>
        {
            entity.HasKey(e => e.ExerciseId).HasName("PK__Exercise__A074AD2F1FEE0ED7");

            entity.ToTable("Exercise");

            entity.Property(e => e.ExerciseId).ValueGeneratedNever();
            entity.Property(e => e.ExerciseType)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Goal).WithMany(p => p.Exercises)
                .HasForeignKey(d => d.GoalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("GoalIdl_fk");
        });

        modelBuilder.Entity<Goal>(entity =>
        {
            entity.HasKey(e => e.GoalId).HasName("PK__Goal__8A4FFFD1B1C4A747");

            entity.ToTable("Goal");

            entity.Property(e => e.GoalId).ValueGeneratedNever();
            entity.Property(e => e.GoalType)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Meal>(entity =>
        {
            entity.HasKey(e => e.MealId).HasName("PK__Meal__ACF6A63D399DE82B");

            entity.ToTable("Meal");

            entity.Property(e => e.MealId).ValueGeneratedNever();
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MealName)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.IdNavigation).WithMany(p => p.Meals)
                .HasForeignKey(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("DailyMealId_fk");
        });

        modelBuilder.Entity<Sleep>(entity =>
        {
            entity.HasKey(e => e.SleepId).HasName("PK__Sleep__54B08AE9EABCF70A");

            entity.ToTable("Sleep");

            entity.Property(e => e.SleepId).ValueGeneratedNever();
            entity.Property(e => e.Dueration).HasColumnType("decimal(2, 2)");
            entity.Property(e => e.EndH).HasColumnName("endH");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.StartH).HasColumnName("startH");

            entity.HasOne(d => d.IdNavigation).WithMany(p => p.Sleeps)
                .HasForeignKey(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("DailySleepId_fk");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__CB9A1CFF096D776C");

            entity.HasIndex(e => e.Age, "UsersAges_index");

            entity.HasIndex(e => new { e.FirstName, e.LastName }, "Users_index");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("userId");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.FirstName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("firstName");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("lastName");
        });

        modelBuilder.Entity<UserHealth>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UserHealth");

            entity.Property(e => e.Height).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.Weight).HasColumnType("decimal(5, 2)");

            entity.HasOne(d => d.User).WithMany()
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("userId_fk");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
