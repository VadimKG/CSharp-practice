using Microsoft.EntityFrameworkCore;
using SmartHome.API.Models;

namespace SmartHome.API.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<SmartDevice> Devices { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
