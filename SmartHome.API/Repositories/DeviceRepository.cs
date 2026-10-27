using SmartHome.API.Data;
using SmartHome.API.Models;
using Microsoft.EntityFrameworkCore;

namespace SmartHome.API.Repositories
{
    public class DeviceRepository : IDeviceRepository
    {
        private readonly AppDbContext _context;

        public DeviceRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(SmartDevice device, CancellationToken cancellationToken)
        {
            await _context.Devices.AddAsync(device, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteAsync(SmartDevice device, CancellationToken cancellationToken)
        {
            _context.Devices.Remove(device);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<SmartDevice>> GetAllAsync(bool? isOn, bool? sortByAlphabet, DeviceType? type, string? searchQuery, CancellationToken cancellationToken, int pageNumber, int pageSize)
        {
            IQueryable<SmartDevice> query = _context.Devices.AsNoTracking();

            if (isOn != null)
            {
                query = query.Where(d => d.IsOn == isOn);
            }

            if (sortByAlphabet == true)
            {
                query = query.OrderBy(fa => fa.Name);
            }

            if (type != null)
            {
                query = query.Where(t => t.Type == type);
            }

            if (!string.IsNullOrWhiteSpace(searchQuery))
            {
                query = query.Where(s => s.Name.ToLower().Contains(searchQuery.ToLower()));
            }

            return await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync(cancellationToken);
        }

        public async Task<SmartDevice?> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _context.Devices
                .AsNoTracking()
                .FirstOrDefaultAsync(d => d.ID == id, cancellationToken);
        }


        public async Task UpdateAsync(SmartDevice device, CancellationToken cancellationToken)
        {
            _context.Devices.Update(device);
            await _context.SaveChangesAsync(cancellationToken);
        }
        public async Task<Dictionary<DeviceType, int>> GetStatsAsync(CancellationToken cancellationToken)
        {
            return await _context.Devices
                   .AsNoTracking()
                   .GroupBy(st => st.Type)
                   .Select(g => new { Key = g.Key, Count = g.Count() })
                   .ToDictionaryAsync(g => g.Key, g => g.Count, cancellationToken);
        }

    }
}
