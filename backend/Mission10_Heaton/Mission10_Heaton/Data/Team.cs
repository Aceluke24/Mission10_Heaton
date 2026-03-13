using System.ComponentModel.DataAnnotations;
using Mission10_Heaton.Data;

namespace Mission10_Heaton.Models;

public partial class Team
{
    [Key]
    public int TeamId { get; set; }
    public string TeamName { get; set; } = null!;
    public int? CaptainId { get; set; }
    public virtual ICollection<Bowler> Bowlers { get; set; } = new List<Bowler>();
}
