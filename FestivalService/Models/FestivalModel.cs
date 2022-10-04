namespace FestivalService.Models;

public class FestivalModel
{
    public Guid Id { get; set; }
    public string FestivalName { get; set; } = null!;
    public string FestivalTimeFrame { get; set; } = null!;
    public string FestivalDay { get; set; } = null!;
    public string FestivalDate { get; set; } = null!;
    public string FestivalAge { get; set; } = null!;
    public string FestivalPrice { get; set; } = null!;
    public string FestivalLocation { get; set; } = null!;
    public int? FestivalOrder { get; set; } = null!;
}   