using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramewcrkFluentAPI.Entites;
using EntityFrameworkFluentAPI.Entites;
using EntityFrameworkFluentAPI.Entites.Mappings;

namespace EntityFrameworkFluentAPI.Context
{
    public class NorthwindContext:DbContext
    {
        
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)   // Burada oluşturduğumuz mapleri ağaya kaldırdık.
        {
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new OrderMap());
        }
    }
}
