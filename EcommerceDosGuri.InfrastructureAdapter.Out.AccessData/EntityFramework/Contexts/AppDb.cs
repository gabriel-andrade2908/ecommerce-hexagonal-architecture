using EcommerceDosGuri.Application.DomainModel.Administration;
using EcommerceDosGuri.Application.DomainModel.Catalog;
using EcommerceDosGuri.InfrastructureAdapter.Out.AccessData.EntityFramework.Customers;
using EcommerceDosGuri.InfrastructureAdapter.Out.AccessData.EntityFramework.Orders;
using Microsoft.EntityFrameworkCore;

namespace EcommerceDosGuri.InfrastructureAdapter.Out.AccessData.EntityFramework.Contexts
{
    public class AppDb : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrderFA());
            modelBuilder.ApplyConfiguration(new CustomerFA());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DbDosGuris;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
