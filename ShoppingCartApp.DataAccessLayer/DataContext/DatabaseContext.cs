using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ShoppingCartApp.DataAccessLayer.Models;

namespace ShoppingCartApp.DataAccessLayer.DataContext
{
    public class DatabaseContext:DbContext
    {
        //public class OptionBuilder
        //{
        //    public OptionBuilder()
        //    {
        //        settings = new AppConfiguration();
        //        opsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
        //        opsBuilder.UseSqlServer(settings.sqlConnectionString);
        //        dbOptions = opsBuilder.Options;

        //    }
        //    public DbContextOptionsBuilder<DatabaseContext> opsBuilder { get; set; }

        //    public DbContextOptions<DatabaseContext> dbOptions { get; set; }
            
        //    private AppConfiguration settings { get; set; }
        //}

        //public static OptionBuilder ops = new OptionBuilder();

        //public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        //{
            
        //}
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var settings = new AppConfiguration();
            optionsBuilder.UseSqlServer(settings.sqlConnectionString);
            base.OnConfiguring(optionsBuilder);
        }

    }
}
