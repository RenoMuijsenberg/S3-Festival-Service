using System.Globalization;
using FestivalService.Models;
using FestivalService.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

    // [HttpGet("festivals/{festivalName}")]
    // public async Task<FestivalModel> GetSingleFestival(string festivalName)
    // {
    //     var festival = await _db.Festivals.FirstAsync(x => x.FestivalName == festivalName);
    //
    //     return festival;
    // }
}