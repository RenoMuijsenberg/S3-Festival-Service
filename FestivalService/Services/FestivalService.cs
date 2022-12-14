using FestivalService.Data.Repositorys;
using FestivalService.Models;
using Microsoft.AspNetCore.Mvc;

namespace FestivalService.Services;

public class FestivalService : IFestivalService
{
    private readonly IFestivalRepository _repository;

    public FestivalService(IFestivalRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<FestivalModel>> GetAllFestivals()
    {
         var festivals = await _repository.GetAllFestivals();
         return festivals.OrderBy(x => x.FestivalOrder).ToList();
    }
    
    public async Task<FestivalModel> GetSpecificFestival(string name)
    {
        return await _repository.GetSpecificFestival(name);
    }

    public bool DeleteAllFestivals()
    {
        return _repository.DeleteAllFestivals();
    }

    public async Task<ActionResult<FestivalModel>> AddRangeOfFestivals(List<FestivalModel> festivalModelList)
    {
        return await _repository.AddRangeOfFestivals(festivalModelList);
    }
}