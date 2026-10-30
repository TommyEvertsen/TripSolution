using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TripDatabase.Models;

    public class TripContext : DbContext
    {
        public TripContext (DbContextOptions<TripContext> options)
            : base(options)
        {
        }

        public DbSet<TripDatabase.Models.Trip> Trip { get; set; } = default!;
    }
