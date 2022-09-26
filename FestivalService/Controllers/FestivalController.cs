using FestivalService.DataContext;
using FestivalService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FestivalService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FestivalController : ControllerBase
{
    private readonly DatabaseContext _db;

    public FestivalController(DatabaseContext db)
    {
        _db = db;
    }
    
    [HttpGet("festivals")]
    public async Task<List<FestivalModel>> GetAllFestivals()
    {
        var festivals = await _db.Festivals.ToListAsync();

        return festivals;
    }
        
}