using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tourism.Model
{
    public class TourismContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<PackageContent> PackageContents { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conn = "Data Source=K-S-K\\SQLEXPRESS01;Initial Catalog=Tourism Management System;Integrated Security = true";
            optionsBuilder.UseSqlServer(conn);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



            //modelBuilder.Entity<PackageContent>().HasOne(b => b.PackageId).WithMany(b => b.p).HasForeignKey(b => b.PackageId).OnDelete(DeleteBehavior.NoAction);

            // modelBuilder.Entity<Package>().HasOne(b => b.UserRole).WithMany(b => b.u).HasForeignKey(b => b.UserRole).OnDelete(DeleteBehavior.NoAction);

            //FOR USER
            modelBuilder.Entity<User>().Property(b => b.FirstName).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.LastName).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.Email).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.Mobile).HasColumnType("varchar(20)").IsRequired();
            // modelBuilder.Entity<User>().Property(b => b.DateOfBirth).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.Gender).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.Password).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.pincode).HasColumnType("varchar(6)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.Password).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.City).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.State).HasColumnType("varchar(20)").IsRequired();

            //FOR ROLE
            modelBuilder.Entity<Role>().Property(b => b.Name).HasColumnType("varchar(200)").IsRequired();

            //FOR PACKAGE
            modelBuilder.Entity<Package>().Property(b => b.Name).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<Package>().Property(b => b.Description).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<Package>().Property(b => b.PackageType).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<Package>().Property(b => b.Destination).HasColumnType("varchar(200)").IsRequired();
            //modelBuilder.Entity<Package>().Property(b => b.TotalDays).HasColumnType("decimal(14,2)").IsRequired();
            // modelBuilder.Entity<Package>().Property(b => b.TotalNights).HasColumnType("decimal(14,2)").IsRequired();
            // modelBuilder.Entity<Package>().Property(b => b.PerPersonAmount).HasColumnType("decimal(14,2)").IsRequired();
            modelBuilder.Entity<Package>().Property(b => b.Inclusion).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<Package>().Property(b => b.Exclusion).HasColumnType("varchar(200)").IsRequired();





        }

    }
}

