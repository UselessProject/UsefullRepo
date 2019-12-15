using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.Data.Sqlite;
using SQLitePCL;

namespace Dreamlines.DAL
{
    public class SalesUnitngContext : DbContext
    {
        public DbSet<SalesUnit> SalesUnits { get; set; }
        public DbSet<Ship> Ships { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            // => options.UseSqlite("Data Source=D:\\Projects\\Dreamlines\\Dreamlines.DAL\\SalesUnit.db");
            => options.UseSqlite("Data Source=SalesUnit.db");
    }

    

    
   
}
