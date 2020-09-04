﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CugemderPortal.Shared.Models
{
    public partial class CugemderDatabaseContext : DbContext
    {
        public CugemderDatabaseContext()
        {
        }

        public CugemderDatabaseContext(DbContextOptions<CugemderDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Genders> Genders { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<JobTitles> JobTitles { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<Points> Points { get; set; }
        public virtual DbSet<Positions> Positions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\cugemder;Database=CugemderDatabase;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Company).HasColumnName("company");

                entity.Property(e => e.CreatedAt).HasColumnName("createdAt");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FirstName).HasColumnName("firstName");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.Group).HasColumnName("group");

                entity.Property(e => e.JobTitle).HasColumnName("jobTitle");

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.Notifications).HasColumnName("notifications");

                entity.Property(e => e.PhotoUrl).HasColumnName("photoUrl");

                entity.Property(e => e.Points).HasColumnName("points");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.Property(e => e.ReferencedBy).HasColumnName("referencedBy");

                entity.Property(e => e.Speciality).HasColumnName("speciality");

                entity.Property(e => e.SurName).HasColumnName("surName");

                entity.Property(e => e.UpdatedAt).HasColumnName("updatedAt");

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasOne(d => d.GenderNavigation)
                    .WithMany(p => p.AspNetUsers)
                    .HasForeignKey(d => d.Gender)
                    .HasConstraintName("FK_AspNetUsers_Genders");

                entity.HasOne(d => d.GroupNavigation)
                    .WithMany(p => p.AspNetUsers)
                    .HasForeignKey(d => d.Group)
                    .HasConstraintName("FK_AspNetUsers_Groups");

                entity.HasOne(d => d.JobTitleNavigation)
                    .WithMany(p => p.AspNetUsers)
                    .HasForeignKey(d => d.JobTitle)
                    .HasConstraintName("FK_AspNetUsers_JobTitles");

                entity.HasOne(d => d.NotificationsNavigation)
                    .WithMany(p => p.AspNetUsers)
                    .HasForeignKey(d => d.Notifications)
                    .HasConstraintName("FK_AspNetUsers_Notifications");

                entity.HasOne(d => d.PointsNavigation)
                    .WithMany(p => p.AspNetUsers)
                    .HasForeignKey(d => d.Points)
                    .HasConstraintName("FK_AspNetUsers_Points");

                entity.HasOne(d => d.PositionNavigation)
                    .WithMany(p => p.AspNetUsers)
                    .HasForeignKey(d => d.Position)
                    .HasConstraintName("FK_AspNetUsers_Positions");
            });

            modelBuilder.Entity<Genders>(entity =>
            {
                entity.Property(e => e.GenderName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Groups>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<JobTitles>(entity =>
            {
                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Notifications>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Summary)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Points>(entity =>
            {
                entity.Property(e => e.AddedBy).IsRequired();

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Positions>(entity =>
            {
                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}