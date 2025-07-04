﻿using Microsoft.EntityFrameworkCore;
using Mango.Services.ShoppingCartAPI.Models;

namespace Mango.Services.ProductAPI.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {  
        }

        public DbSet<CartHeader> CartHeaders { get; set; }
        public DbSet<CartDetails> CartDetails { get; set; }

    }
}
