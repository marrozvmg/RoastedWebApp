using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RoastedWebApp.Models;

namespace RoastedWebApp.Data
{
    public class RoastedWebAppContext : DbContext
    {
        public RoastedWebAppContext (DbContextOptions<RoastedWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<RoastedWebApp.Models.Customer> Customer { get; set; }

        public DbSet<RoastedWebApp.Models.Order> Order { get; set; }

        public DbSet<RoastedWebApp.Models.Product> Product { get; set; }

        public DbSet<RoastedWebApp.Models.ProductType> ProductType { get; set; }
    }
}
