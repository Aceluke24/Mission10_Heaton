namespace Mission10_Heaton.Data;
using Microsoft.EntityFrameworkCore;

public class BowlerDbContext :  DbContext
{
    
    public BowlerDbContext(DbContextOptions<BowlerDbContext> options) : base(options)
    {
        
    }

    public DbSet<Bowler> Bowlers { get; set; }
    public DbSet<Teams> Team { get; set; }
    
}
