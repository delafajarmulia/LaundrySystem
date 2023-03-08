using LaundrySystem.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundrySystem
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring (optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;database=laundrydb;Trusted_Connection=true;TrustServerCertificate=True");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<DetailPackage> DetailPackages { get; set; }
        public DbSet<DetailTransaction> DetailTransactions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<HeaderTransaction> HeaderTransactions { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Unit> Units { get; set; }

        // VIEW //
        public DbSet<ViewManageEmployee> viewManageEmployees { get; set; }
        public DbSet<ViewManageService> viewManageServices { get; set; }
        public DbSet<ViewManagePackage> viewManagePackages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>(c =>
            {
                c.HasKey(x => x.IdCategory);
            });

            modelBuilder.Entity<Customer>(c =>
            {
                c.HasKey(x => x.IdCustomer);
            });

            modelBuilder.Entity<DetailPackage>(c =>
            {
                c.HasKey(x => x.IdDetailPackage);
            });

            modelBuilder.Entity<DetailTransaction>(c =>
            {
                c.HasKey(x => x.IdDetailTransaction);
            });

            modelBuilder.Entity<Employee>(c =>
            {
                c.HasKey(x => x.IdEmployee);
            });

            modelBuilder.Entity<HeaderTransaction>(c =>
            {
                c.HasKey(x => x.IdHeaderTransaction);
            });

            modelBuilder.Entity<Job>(c =>
            {
                c.HasKey(x => x.IdJob);
            });

            modelBuilder.Entity<Package>(c =>
            {
                c.HasKey(x => x.IdPackage);
            });

            modelBuilder.Entity<Service>(c =>
            {
                c.HasKey(x => x.IdService);
            });

            modelBuilder.Entity<Unit>(c =>
            {
                c.HasKey(x => x.IdUnit);
            });

            // VIEW //
            modelBuilder.Entity<ViewManageEmployee>(c =>
            {
                c.HasKey(x => x.IdEmployee);
                c.ToView("ViewManageEmployee");  
            });

            modelBuilder.Entity<ViewManageService>(c =>
            {
                c.HasKey(x => x.IdService);
                c.ToView("ViewManageService");
            });

            modelBuilder.Entity<ViewManagePackage>(v =>
            {
                v.HasKey(x => x.IdService);
                v.ToView("ViewManagePackage");
            });
        }
    }
}
