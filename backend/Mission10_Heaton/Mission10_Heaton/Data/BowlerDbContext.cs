using Microsoft.EntityFrameworkCore;
using Mission10_Heaton.Models;

namespace Mission10_Heaton.Data;

public class BowlerDbContext : DbContext
{
    public BowlerDbContext(DbContextOptions<BowlerDbContext> options) : base(options)
    {
        
    }

    public DbSet<Bowler> Bowlers { get; set; }
    public DbSet<Team> Teams { get; set; }
}