using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public class RestaurantRaterDbContext : DbContext
    {
        public RestaurantRaterDbContext(DbContextOptions<RestaurantRaterDbContext> options) : base(options) {}
    }
