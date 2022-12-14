using FestivalService.Models;
using FestivalService.Services;
using Microsoft.AspNetCore.Mvc;

namespace FestivalService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FestivalController : ControllerBase
{
    private readonly IFestivalService _service;

    public FestivalController(IFestivalService service)
    {
        _service = service;
    }
    
    [HttpGet("festivals")]
    public async Task<List<FestivalModel>> GetAllFestivals()
    {
        return await _service.GetAllFestivals();
    }

    [HttpGet("festivals/{festivalName}")]
    public async Task<FestivalModel> GetSingleFestival(string festivalName)
    {
        return await _service.GetSpecificFestival(festivalName);
    }

    [HttpDelete("festivals/all")]
    public bool DeleteAllFestivals()
    {
        return _service.DeleteAllFestivals();
    }

    [HttpPost]
    public async Task<ActionResult<FestivalModel>> AddRangeOfFestivals(List<FestivalModel> festivalModelList)
    {
        return await _service.AddRangeOfFestivals(festivalModelList);
    }
}