﻿using Microsoft.EntityFrameworkCore;
using RetailInventory.Entities;

namespace RetailInventory.DbConfig
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }      
        public DbSet<Category> Categories { get; set; }   

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=RetailInventoryDb;Trusted_Connection=True;");
        }
    }
}
