using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //Db tabloları ile proje dosyalarını bağlar.

    public class RentalContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Rental;Trusted_Connection=true");
        }

        public DbSet<Car> cars { get; set; }

        public DbSet<Brand> brands { get; set; }

        public DbSet<Color> colors { get; set; }

        public DbSet<Rental> rentals { get; set; }

        public DbSet<CarImage> carImages { get; set; }
        //public DbSet<Customer> customers { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }

        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }  
    }

}
