﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication01.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions options) : base(options)
        {

        }
        public DbSet<CostumerModels> Customers { get; set; }
    }
}
