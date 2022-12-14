using FestivalService.Models;
using Microsoft.AspNetCore.Mvc;

namespace FestivalService.Data.Repositorys;

public interface IFestivalRepository
{
    Task<List<FestivalModel>> GetAllFestivals();
    Task<FestivalModel> GetSpecificFestival(string name);
    bool DeleteAllFestivals();
    Task<ActionResult<FestivalModel>> AddRangeOfFestivals(List<FestivalModel> festivalList);
}