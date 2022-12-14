using FestivalService.Models;
using Microsoft.AspNetCore.Mvc;

namespace FestivalService.Services;

public interface IFestivalService
{
    Task<List<FestivalModel>> GetAllFestivals();
    Task<FestivalModel> GetSpecificFestival(string name);
    bool DeleteAllFestivals();
    Task<ActionResult<FestivalModel>> AddRangeOfFestivals(List<FestivalModel> festivalList);
}