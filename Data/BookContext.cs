﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookShopMvcBasic.Models;

namespace BookShopMvcBasic.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {

         }
            public DbSet<Book> Books { get; set; }
            public DbSet<Comment> Comments { get; set; }
            public DbSet<Category> Categories { get; set; }
            public DbSet<CategoryBook> CategoryBooks { get; set; }
            public DbSet<Seller> Sellers { get; set; }
            public DbSet<SellerBook> SellerBooks { get; set; }

    }
}
