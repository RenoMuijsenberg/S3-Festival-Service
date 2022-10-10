using FestivalService.Models;
using Microsoft.EntityFrameworkCore;

namespace FestivalService.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<FestivalModel> Festivals { get; set; } = null!;
    }
}