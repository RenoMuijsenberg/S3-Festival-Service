using FestivalService.Models;

namespace FestivalService.Data.Repositorys;

public interface IFestivalRepository
{
    Task<List<FestivalModel>> GetAllFestivals();
    Task<FestivalModel> GetSpecificFestival(string name);
    bool DeleteAllFestivals();
}