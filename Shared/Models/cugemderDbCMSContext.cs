using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CugemderPortal.Shared.Models
{
    public partial class cugemderDbCMSContext : DbContext
    {
        public cugemderDbCMSContext()
        {
        }

        public cugemderDbCMSContext(DbContextOptions<cugemderDbCMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=(localdb)\\cugemder; Database=cugemderDbCMS; Trusted_Connection=True; MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("IX_AspNetUsers");

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

                entity.HasOne(d => d.GroupNavigation)
                    .WithMany(p => p.AspNetUsers)
                    .HasForeignKey(d => d.Group)
                    .HasConstraintName("FK_AspNetUsers_AspNetUsers");
            });

            modelBuilder.Entity<Groups>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
