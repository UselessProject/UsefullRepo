using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.Data.Sqlite;
using SQLitePCL;

namespace Dreamlines.DAL
{
    public class SalesunitContext : DbContext
    {
        public SalesunitContext()
        { }
        public SalesunitContext(DbContextOptions<SalesunitContext> options)
        : base(options)
        { }

        public DbSet<Salesunit> Salesunits { get; set; }
        public DbSet<Ship> Ships { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            // => options.UseSqlite("Data Source=D:\\Projects\\Dreamlines\\Dreamlines.DAL\\Salesunit.db");
            => options.UseSqlServer("Data Source=.;Initial Catalog=DreamlinesDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }

    

    
   
}
