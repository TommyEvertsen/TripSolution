using Microsoft.EntityFrameworkCore;

public class TripContext : DbContext
{
    public TripContext(DbContextOptions<TripContext> options)
        : base(options) { }

    public DbSet<TripDatabase.Models.Trip> Trip { get; set; } = default!;
}
