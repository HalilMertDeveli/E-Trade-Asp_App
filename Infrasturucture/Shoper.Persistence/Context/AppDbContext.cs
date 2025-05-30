﻿using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Shoper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoper.Persistence.Context
{
    public class AppDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost; database=Shoper;Integrated Security=True;TrustServerCertificate=True;");
        }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Town> Town { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<Help> Helps { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Favorites> Favorites { get; set; }

        //public List<Customer> GetAllCustomer()
        //{
        //    return Customers.FromSqlRaw("EXEC dbo.getallcustomer").ToList();
        //}
        //public List<Customer> GetAllCustomerFiltre(int userId, DateTime startDate, DateTime endDate)
        //{
        //    var userIdParam = new SqlParameter("@UserId", userId);
        //    var startDateParam = new SqlParameter("@StartDate", startDate);
        //    var endDateParam = new SqlParameter("@EndDate", endDate);

        //    return Customers.FromSqlRaw("EXEC dbo.getallcustomer @UserId, @StartDate, @EndDate", userIdParam, startDateParam, endDateParam).ToList();
        //}

    }
}
