using Microsoft.EntityFrameworkCore;
using SmartHome.Core.Models;
using SmartHome.Core.Repositories;
using SmartHome.Infrastructure.Data;

namespace SmartHome.Infrastructure.Repositories;

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

    public async Task<List<SmartDevice>> GetAllAsync(
        bool? isOn,
        bool? sortByAlphabet,
        DeviceType? type,
        string? searchQuery,
        CancellationToken cancellationToken,
        int pageNumber,
        int pageSize)
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

    public async Task<SmartDevice?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        return await _context.Devices
            .Where(d => d.ID == id)
            .FirstOrDefaultAsync(cancellationToken);
    }

    public async Task<Dictionary<DeviceType, int>> GetStatsAsync(CancellationToken cancellationToken = default)
    {
        return await _context.Devices
            .GroupBy(d => d.Type)
            .Select(g => new { Type = g.Key, Count = g.Count() })
            .ToDictionaryAsync(x => x.Type, x => x.Count, cancellationToken);
    }

    public async Task UpdateAsync(SmartDevice device, CancellationToken cancellationToken)
    {
        _context.Devices.Update(device);
        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task<IEnumerable<SmartDevice>> GetByTypeAsync(DeviceType type, CancellationToken cancellationToken = default)
    {
        return await _context.Devices
            .Where(d => d.Type == type)
            .ToListAsync(cancellationToken);
    }
}