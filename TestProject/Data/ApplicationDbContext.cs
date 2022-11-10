using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

using TestProject.Models;

namespace TestProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Address> Addresses{ get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<SalesorderDetail> SalesorderDetail { get; set; }
    }
}
