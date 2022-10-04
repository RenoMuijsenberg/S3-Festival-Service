using FestivalService.Models;
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
}