using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FestivalService.Models;

public class FestivalModel
{
    public Guid Id { get; set; }
    public string FestivalName { get; set; }
    public string FestivalTimeFrame { get; set; }
    public string FestivalDay { get; set; }
    public string FestivalDate { get; set; }
    public string FestivalAge { get; set; }
    public string FestivalPrice { get; set; }
    public string FestivalLocation { get; set; }
    public int? FestivalOrder { get; set; }
}   