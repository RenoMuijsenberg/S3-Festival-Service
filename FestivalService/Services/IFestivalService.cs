using FestivalService.Models;

namespace FestivalService.Services;

public interface IFestivalService
{
    Task<List<FestivalModel>> GetAllFestivals();
}