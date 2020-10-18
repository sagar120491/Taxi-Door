using Microsoft.EntityFrameworkCore;
using Brainwork.TAXI.Data;

namespace Brainwork.TAXI.Persistence
{
    public class TAXIContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Bid> Bids { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Fare> Fares { get; set; }
        public DbSet<RateCard> RateCards { get; set; }
        public DbSet<Training> Trainings { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data Source=DESKTOP-H0EBIT3\SQLEXPRESS;Initial Catalog=TAXI;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().Property(b => b.FirstName).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<Customer>().Property(b => b.LastName).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<Customer>().Property(b => b.Mobile).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<Customer>().Property(b => b.Email).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<Customer>().Property(b => b.Username).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<Customer>().Property(b => b.Password).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<Customer>().Property(b => b.Status).HasColumnType("varchar(50)");

            modelBuilder.Entity<Driver>().Property(b => b.FirstName).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<Driver>().Property(b => b.LastName).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<Driver>().Property(b => b.Mobile).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<Driver>().Property(b => b.Email).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<Driver>().Property(b => b.Username).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<Driver>().Property(b => b.Password).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<Driver>().Property(b => b.LicenceNumber).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<Driver>().Property(b => b.AdharNumber).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<Driver>().Property(b => b.PAN).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<Driver>().Property(b => b.Status).HasColumnType("varchar(50)");
            modelBuilder.Entity<Driver>().HasOne(b => b.Vendor).WithMany(b => b.Drivers).HasForeignKey(b => b.VendorId).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Vendor>().Property(b => b.FirstName).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<Vendor>().Property(b => b.LastName).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<Vendor>().Property(b => b.Mobile).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<Vendor>().Property(b => b.Email).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<Vendor>().Property(b => b.Username).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<Vendor>().Property(b => b.Password).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<Vendor>().Property(b => b.Address).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<Vendor>().Property(b => b.AdharNumber).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<Vendor>().Property(b => b.PAN).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<Vendor>().Property(b => b.Status).HasColumnType("varchar(50)");

            modelBuilder.Entity<Vehicle>().Property(b => b.CarType).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<Vehicle>().Property(b => b.RegistrationNumber).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<Vehicle>().Property(b => b.Image).HasColumnType("varchar(200)");
            modelBuilder.Entity<Vehicle>().Property(b => b.FuelType).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<Vehicle>().Property(b => b.Status).HasColumnType("varchar(50)");
            //  modelBuilder.Entity<Vehicle>().HasOne(b => b.Vendor).WithMany(b => b.Vehicles).HasForeignKey(b => b.VendorId).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Booking>().Property(b => b.Type).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<Booking>().Property(b => b.Source).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<Booking>().Property(b => b.Destination).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<Booking>().Property(b => b.RequestAmount).HasColumnType("decimal(10,2)").IsRequired();
            modelBuilder.Entity<Booking>().Property(b => b.FinalAmount).HasColumnType("decimal(10,2)").IsRequired();
            modelBuilder.Entity<Booking>().Property(b => b.Status).HasColumnType("varchar(50)");

            modelBuilder.Entity<Bid>().Property(b => b.Amount).HasColumnType("decimal(10,2)").IsRequired();
            modelBuilder.Entity<Bid>().Property(b => b.Status).HasColumnType("varchar(50)");
            modelBuilder.Entity<Bid>().HasOne(b => b.Vehicle).WithMany(b => b.Bids).HasForeignKey(b => b.VehicleId).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Account>().Property(b => b.AvailableBalance).HasColumnType("decimal(10,2)").IsRequired();
            modelBuilder.Entity<Account>().Property(b => b.Penalty).HasColumnType("decimal(10,2)").IsRequired();
            modelBuilder.Entity<Account>().Property(b => b.BonusAmount).HasColumnType("decimal(10,2)").IsRequired();
            modelBuilder.Entity<Account>().Property(b => b.TotalBonus).HasColumnType("decimal(10,2)").IsRequired();

            modelBuilder.Entity<Fare>().Property(b => b.RatePerExtraKM).HasColumnType("decimal(10,2)").IsRequired();
            modelBuilder.Entity<Fare>().Property(b => b.TotalAmount).HasColumnType("decimal(10,2)").IsRequired();
            modelBuilder.Entity<Fare>().Property(b => b.Commission).HasColumnType("decimal(10,2)").IsRequired();
            modelBuilder.Entity<Fare>().Property(b => b.TaxGST).HasColumnType("decimal(10,2)").IsRequired();

            modelBuilder.Entity<RateCard>().Property(b => b.CarType).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<RateCard>().Property(b => b.RatePerKM).HasColumnType("decimal(10,2)").IsRequired();
            modelBuilder.Entity<RateCard>().Property(b => b.NightAllowance).HasColumnType("decimal(10,2)");

            modelBuilder.Entity<Training>().Property(b => b.UserType).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<Training>().Property(b => b.Language).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<Training>().Property(b => b.URL).HasColumnType("varchar(500)").IsRequired();


        }

    }
}
