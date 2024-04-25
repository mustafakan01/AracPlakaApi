﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;



namespace CarManagement.Data
{
    public class AppDbContext:DbContext
    {
        


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Car> Cars { get; set; }
    }
}
