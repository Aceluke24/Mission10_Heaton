using Mission10_Heaton.Data;

namespace Mission10_Heaton.Controllers;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class BowlerController : ControllerBase
{
    private BowlerDbContext _dbContext;

    public BowlerController(BowlerDbContext temp)
    {
        _dbContext = temp;
    }
    
    [HttpGet(Name = "GetBowlers")]
    public IEnumerable<Bowler> Get()
    {
        var bowlers = _dbContext.Bowlers.ToList();

        return (bowlers);

    }
}