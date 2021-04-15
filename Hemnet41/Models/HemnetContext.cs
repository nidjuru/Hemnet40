using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Hemnet41.Models
{
    public partial class HemnetContext : DbContext
    {
        public HemnetContext()
        {
        }

        public HemnetContext(DbContextOptions<HemnetContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Brooker> Brookers { get; set; }
        public virtual DbSet<Coordinate> Coordinates { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Objekt> Objekts { get; set; }
        public virtual DbSet<RegOfIntrest> RegOfIntrests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=HemnetDB");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Brooker>(entity =>
            {
                entity.ToTable("Brooker");

                entity.Property(e => e.BrookerId).HasColumnName("Brooker_ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("First_name");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Last_name");
            });

            modelBuilder.Entity<Coordinate>(entity =>
            {
                entity.Property(e => e.Latitude)
                    .HasColumnType("decimal(9, 7)")
                    .HasColumnName("latitude");

                entity.Property(e => e.Longitude)
                    .HasColumnType("decimal(9, 7)")
                    .HasColumnName("longitude");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("First_name");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Last_name");
            });

            modelBuilder.Entity<Objekt>(entity =>
            {
                entity.HasKey(e => e.HouseId)
                    .HasName("PK__Objekt__E397A3B9C7E8C6D7");

                entity.ToTable("Objekt");

                entity.Property(e => e.HouseId).HasColumnName("House_ID");

                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.BiArea).HasColumnName("Bi_area");

                entity.Property(e => e.BrookerId).HasColumnName("Brooker_ID");

                entity.Property(e => e.BuildYear).HasColumnName("Build_year");

                entity.Property(e => e.Descriptions)
                    .HasMaxLength(455)
                    .IsUnicode(false);

                entity.Property(e => e.FormOfLease)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Form_of_lease");

                entity.Property(e => e.HousingType)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Housing_type");

                entity.Property(e => e.Images)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LivingArea).HasColumnName("Living_area");

                entity.Property(e => e.PlotArea).HasColumnName("Plot_area");

                entity.Property(e => e.ShowingDate)
                    .HasColumnType("date")
                    .HasColumnName("Showing_date");

                entity.HasOne(d => d.Brooker)
                    .WithMany(p => p.Objekts)
                    .HasForeignKey(d => d.BrookerId)
                    .HasConstraintName("FK__Objekt__Brooker___35BCFE0A");

                entity.HasOne(d => d.Coordinate)
                    .WithMany(p => p.Objekts)
                    .HasForeignKey(d => d.CoordinateId)
                    .HasConstraintName("FK__Objekt__Coordina__4D94879B");
            });

            modelBuilder.Entity<RegOfIntrest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RegOfIntrest");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.HouseId).HasColumnName("House_ID");

                entity.HasOne(d => d.Customer)
                    .WithMany()
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RegOfIntr__Custo__29572725");

                entity.HasOne(d => d.House)
                    .WithMany()
                    .HasForeignKey(d => d.HouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RegOfIntr__House__286302EC");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
