using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramewcrkFluentAPI.Entites;

namespace EntityFrameworkFluentAPI.Entites.Mappings
{
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            this.HasKey(o => o.OrderID);
            this.Property(o => o.CustomerID).IsFixedLength().HasMaxLength(5);        // Burada CustomerID yi uzunluğunu sabit tutuk ve karekter uzunluğunu 5 yaptık.
            this.Property(o => o.ShipName).HasMaxLength(40);
            this.Property(o => o.ShipCity).HasMaxLength(15);
            this.Property(o => o.ShipCountry).HasMaxLength(15);
            this.ToTable("Orders");
            this.Property(o => o.OrderID).HasColumnName("OrderID");
            this.Property(o => o.CustomerID).HasColumnName("CustomerID");
            this.Property(o => o.ShipName).HasColumnName("ShipName");
            this.Property(o => o.ShipCity).HasColumnName("ShipCity");
            this.Property(o => o.ShipCountry).HasColumnName("ShipCountry");
            this.Property(o => o.OrderDate).HasColumnName("OrderDate");


            this.HasOptional(c => c.Customer).
                WithMany(o => o.Orders).
                HasForeignKey(f => f.CustomerID);            // Burada foreignkey belirledik ve birden coğa ilişkisini kurduk.



        }
    }
}
