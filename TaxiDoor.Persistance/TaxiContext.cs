using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TaxiDoor.Data;

namespace TaxiDoor.Persistance
{
    public class TaxiContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Vehicle> Vehicles{ get; set; }
        public DbSet<Bid> Bids { get; set; }
        public DbSet<Fare> Fares { get; set; }
        public DbSet<Traning> Tranings { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = " Data Source = DESKTOP-1C1RMPK\\SQLEXPRESS; Initial Catalog=TaxiDoor; Integrated Security=true;";
            optionsBuilder.UseSqlServer(connectionString);

            


    
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Customer>().Property(b => b.FirstName).HasColumnType("varchar(100)").IsRequired();

            modelBuilder.Entity<Customer>().Property(b => b.LastName).HasColumnType("varchar(100)").IsRequired();
            modelBuilder.Entity<Customer>().Property(b => b.Mobile).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<Customer>().Property(b => b.Email).HasColumnType("varchar(100)");
            modelBuilder.Entity<Customer>().Property(b => b.UserName).HasColumnType("varchar(100)").IsRequired();
            modelBuilder.Entity<Customer>().Property(b => b.Password).HasColumnType("varchar(10)").IsRequired();
           
            modelBuilder.Entity<Customer>().Property(b => b.Status).HasColumnType("varchar(10)").IsRequired();

            modelBuilder.Entity<Booking>().Property(b => b.Type).HasColumnType("varchar(100)").IsRequired();
            modelBuilder.Entity<Booking>().Property(b => b.Source).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<Booking>().Property(b => b.Destination).HasColumnType("varchar(100)");
            modelBuilder.Entity<Booking>().Property(b => b.Date).HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<Booking>().Property(b => b.Time).HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<Booking>().Property(b => b.RequestedAmount).HasColumnType("decimal(14,2)").IsRequired();
            modelBuilder.Entity<Booking>().Property(b => b.FinalAmount).HasColumnType("decimal(12,2)").IsRequired();
            modelBuilder.Entity<Booking>().Property(b => b.Status).HasColumnType("varchar(10)").IsRequired();


            modelBuilder.Entity<Booking>().HasOne(b => b.Vendors).WithMany(b => b.Bookings).HasForeignKey(b => b.VendorId).OnDelete(DeleteBehavior.NoAction);//.onDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<Vendor>().Property(b => b.FirstName).HasColumnType("varchar(100)").IsRequired();
            modelBuilder.Entity<Vendor>().Property(b => b.LastName).HasColumnType("varchar(100)").IsRequired();
            modelBuilder.Entity<Vendor>().Property(b => b.Mobile).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<Vendor>().Property(b => b.Email).HasColumnType("varchar(100)");
            modelBuilder.Entity<Vendor>().Property(b => b.UserName).HasColumnType("varchar(100)").IsRequired();
            modelBuilder.Entity<Vendor>().Property(b => b.Password).HasColumnType("varchar(10)").IsRequired();
            modelBuilder.Entity<Vendor>().Property(b => b.Address).HasColumnType("varchar(500)").IsRequired();
            modelBuilder.Entity<Vendor>().Property(b => b.AdharNumber).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<Vendor>().Property(b => b.PanNumber).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<Vendor>().Property(b => b.Status).HasColumnType("varchar(10)").IsRequired();

            modelBuilder.Entity<Driver>().Property(b => b.FirstName).HasColumnType("varchar(100)").IsRequired();
            modelBuilder.Entity<Driver>().Property(b => b.LastName).HasColumnType("varchar(100)").IsRequired();
            modelBuilder.Entity<Driver>().Property(b => b.Mobile).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<Driver>().Property(b => b.Email).HasColumnType("varchar(100)");
            modelBuilder.Entity<Driver>().Property(b => b.UserName).HasColumnType("varchar(100)").IsRequired();
            modelBuilder.Entity<Driver>().Property(b => b.Password).HasColumnType("varchar(10)").IsRequired();
            modelBuilder.Entity<Driver>().Property(b => b.Address).HasColumnType("varchar(500)").IsRequired();
            modelBuilder.Entity<Driver>().Property(b => b.LicenceNumber).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<Driver>().Property(b => b.AdharNumber).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<Driver>().Property(b => b.PanNumber).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<Driver>().Property(b => b.Status).HasColumnType("varchar(10)").IsRequired();

            modelBuilder.Entity<Vehicle>().Property(b => b.VehicleType).HasColumnType("varchar(100)").IsRequired();
            modelBuilder.Entity<Vehicle>().Property(b => b.RegistrationNumber).HasColumnType("varchar(100)").IsRequired();
            modelBuilder.Entity<Vehicle>().Property(b => b.Image).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<Vehicle>().Property(b => b.FuelType).HasColumnType("varchar(100)");
            modelBuilder.Entity<Vehicle>().Property(b => b.Status).HasColumnType("varchar(100)").IsRequired();

            modelBuilder.Entity<Bid>().Property(b => b.Amount).HasColumnType("decimal(12,2)").IsRequired();
            modelBuilder.Entity<Bid>().Property(b => b.Status).HasColumnType("varchar(10)").IsRequired();
            modelBuilder.Entity<Bid>().HasOne(b => b.Vehicles).WithMany(b => b.Bids).HasForeignKey(b => b.VehicleId).OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<Fare>().Property(b => b.ExtraDistance).HasColumnType("decimal(12,2)").IsRequired();
            modelBuilder.Entity<Fare>().Property(b => b.RatePerExtraKM).HasColumnType("decimal(12,2)").IsRequired();
            modelBuilder.Entity<Fare>().Property(b => b.TotalAmount).HasColumnType("decimal(12,2)").IsRequired();
            modelBuilder.Entity<Fare>().Property(b => b.Commission).HasColumnType("decimal(12,2)").IsRequired();
            modelBuilder.Entity<Fare>().Property(b => b.Tax).HasColumnType("decimal(12,2)").IsRequired();


            modelBuilder.Entity<Account>().Property(b => b.AvailableBalance).HasColumnType("decimal(12,2)").IsRequired();
            modelBuilder.Entity<Account>().Property(b => b.Penalty).HasColumnType("decimal(12,2)").IsRequired();
            modelBuilder.Entity<Account>().Property(b => b.BonusAmount).HasColumnType("decimal(12,2)").IsRequired();
            modelBuilder.Entity<Account>().Property(b => b.TotalBonus).HasColumnType("decimal(12,2)").IsRequired();
            modelBuilder.Entity<Account>().Property(b => b.Date).HasColumnType("datetime").IsRequired();

            modelBuilder.Entity<Traning>().Property(b => b.UserType).HasColumnType("varchar(10)").IsRequired();
            modelBuilder.Entity<Traning>().Property(b => b.Language).HasColumnType("varchar(10)").IsRequired();
            modelBuilder.Entity<Traning>().Property(b => b.URL).HasColumnType("varchar(10)").IsRequired();
        }



    }



}
