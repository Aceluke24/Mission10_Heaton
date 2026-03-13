using System.ComponentModel.DataAnnotations;

namespace Mission10_Heaton.Data;

public class Teams
{
    [Key]
    public int TeamId { get; set; }
    [Required]
    public string TeamName { get; set; }
    [Required]
    public int CaptainId { get; set; }
    public ICollection<Bowler> Bowlers { get; set; }
}