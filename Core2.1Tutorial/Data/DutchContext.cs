using DutchTreat.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core2._1Tutorial.Data
{
    public class DutchContext : DbContext
    {
        //This constructor takes the options passed in startup and passes them to the base
        //context class
        public DutchContext(DbContextOptions<DutchContext> options) : base(options) { }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        //We don't create a DbSet for OrderItem because we'd only
        //access OrderItem from Orders
    }
}
