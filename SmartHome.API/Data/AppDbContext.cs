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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SmartDevice>().HasData(
                new SmartDevice { ID = 2, Name = "Apple Lamp", IsOn = false, Type = DeviceType.Lamp },
                new SmartDevice { ID = 3, Name = "Smart Speaker", IsOn = true, Type = DeviceType.Speaker },
                new SmartDevice { ID = 4, Name = "Camera", IsOn = true, Type = DeviceType.Camera }
            );  
        }
    }
}
