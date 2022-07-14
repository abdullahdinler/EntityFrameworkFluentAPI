using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramewcrkFluentAPI.Entites;

namespace EntityFrameworkFluentAPI.Entites.Mappings
{
    public class CustomerMap:EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            this.HasKey(c => c.CustomerID);                                     // Burada CustomerID yi primerkey yaptık ve bu sutun bos gecilemez yaptık.
            this.Property(c=> c.CustomerID).IsRequired().HasMaxLength(5);       // Burada CustomerID yi karekter uzunluğunu 5 yaptık ve bu sutun bos gecilemez yaptık.
            this.Property(c => c.CompanyName).IsRequired().HasMaxLength(40);    // Burada CompanyName karekter uzuluğunu 40 yaptık ve bu sutun bos gecilemez yaptık.
            this.Property(c => c.City).HasMaxLength(15);                        // Burada City'yi katekter uzunluğunu 15 yaptık. Boş gecilebilir ayarladik.
            this.Property(c=>c.ContactName).HasMaxLength(30);                   // Burada ContactName'i katekter uzunluğunu 30 yaptık. Boş gecilebilir ayarladik.
            this.Property(c => c.Country).HasMaxLength(15);                     // Burada Country'yi katekter uzunluğunu 15 yaptık. Boş gecilebilir ayarladik.
            this.ToTable("Customers");                                                 // Tablonun varsayılan ismini Customers olsun dedik.
            this.Property(c => c.CustomerID).HasColumnName("CustomerID");       // Burada veri tabanına kayıt olacak sutun adını belirledik.
            this.Property(c => c.ContactName).HasColumnName("ContactName");
            this.Property(c => c.CompanyName).HasColumnName("CompanyName");
            this.Property(c => c.City).HasColumnName("City");
            this.Property(c => c.Country).HasColumnName("Country");




        }
    }
}
