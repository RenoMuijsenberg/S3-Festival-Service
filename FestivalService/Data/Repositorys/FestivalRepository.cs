using FestivalService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FestivalService.Data.Repositorys;

public class FestivalRepository : IFestivalRepository
{
    private readonly DatabaseContext _db;

    public FestivalRepository(DatabaseContext db)
    {
        _db = db;
    }
    
    public async Task<List<FestivalModel>> GetAllFestivals()
    {
        return await _db.Festivals.ToListAsync();
    }
    
    public async Task<FestivalModel> GetSpecificFestival(string name)
    {
        return await _db.Festivals.FirstAsync(x => x.FestivalName == name);
    }
    
    public bool DeleteAllFestivals()
    {
        var result = _db.Database.ExecuteSqlRaw("TRUNCATE TABLE festivals");

        return result != 0;
    }

    public async Task<ActionResult<FestivalModel>> AddRangeOfFestivals(List<FestivalModel> festivalList)
    {
        _db.Festivals.AddRange(festivalList);
        await _db.SaveChangesAsync();

        return new ActionResult<FestivalModel>(new OkResult());
    }
}   