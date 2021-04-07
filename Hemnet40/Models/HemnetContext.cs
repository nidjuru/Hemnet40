using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Hemnet40.Models
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

        public virtual DbSet<Brooker> Brooker { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Objekt> Objekt { get; set; }
        public virtual DbSet<RegOfIntrest> RegOfIntrest { get; set; }





        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Hemnet;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brooker>(entity =>
            {
                entity.Property(e => e.BrookerId).HasColumnName("Brooker_ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("First_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("First_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Objekt>(entity =>
            {
                entity.HasKey(e => e.HouseId)
                    .HasName("PK__Objekt__E397A3B9C7E8C6D7");

                entity.Property(e => e.HouseId).HasColumnName("House_ID");

                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.BiArea).HasColumnName("Bi_area");

                entity.Property(e => e.BrookerId).HasColumnName("Brooker_ID");

                entity.Property(e => e.BuildYear).HasColumnName("Build_year");

                entity.Property(e => e.Descriptions)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FormOfLease)
                    .IsRequired()
                    .HasColumnName("Form_of_lease")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HousingType)
                    .IsRequired()
                    .HasColumnName("Housing_type")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Images)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LivingArea).HasColumnName("Living_area");

                entity.Property(e => e.PlotArea).HasColumnName("Plot_area");

                entity.Property(e => e.ShowingDate)
                    .HasColumnName("Showing_date")
                    .HasColumnType("date");

                entity.HasOne(d => d.Brooker)
                    .WithMany(p => p.Objekt)
                    .HasForeignKey(d => d.BrookerId)
                    .HasConstraintName("FK__Objekt__Brooker___35BCFE0A");
            });

            modelBuilder.Entity<RegOfIntrest>(entity =>
            {
                entity.HasNoKey();

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
