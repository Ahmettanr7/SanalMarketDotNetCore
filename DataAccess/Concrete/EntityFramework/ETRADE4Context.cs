using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class ETRADE4Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=AHMETTAN;Database=ETRADE4;Trusted_Connection=True");
        }

        public DbSet<Address> address { get; set; }
        public DbSet<Cart> carts { get; set; }
        public DbSet<Cart> category1 { get; set; }
        public DbSet<City> cities { get; set; }
        public DbSet<Country> countries { get; set; }
        public DbSet<District> districts { get; set; }
        public DbSet<Favorite> favorites { get; set; }
        public DbSet<ImagePath> images_paths { get; set; }
        public DbSet<Item> items { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderDetail> order_details { get; set; }
        public DbSet<Payment> payments { get; set; }
        public DbSet<Town> towns { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users2 { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}