using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocalERP.Models;
using Microsoft.EntityFrameworkCore;

namespace LocalERP.Contexts
{
    public class VendorContext : DbContext
    {
        public VendorContext(DbContextOptions<VendorContext> options)
            : base(options)
        { }
        public DbSet<Vendor> Vendors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vendor>().HasData(
                   
                new Vendor
                {
                    ID = 1,
                    Name = "Dakota Fisher",
                    PhoneNumber = "306-420-6969",
                    Email = "IsellSwag@gmail.com",
                    WebsiteURL = "Swag.swag"
                }
                );

        }
    }
}
