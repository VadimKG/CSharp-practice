using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartHome.API.Data;
using SmartHome.API.DTOs;
using SmartHome.API.Models;

namespace SmartHome.API.Services
{
    public class DeviceService : IDeviceService
    {
        private readonly AppDbContext _context;

        public DeviceService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<DeviceResponseDto>> GetAll(bool? isOn, bool? sortByAlphabet, DeviceType? type, string? searchQuery, int pageNumber, int pageSize)
        {
            IQueryable<SmartDevice> query = _context.Devices;
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


            return await query.Select(d => new DeviceResponseDto 
                         { 
                            Id = d.ID,
                            Name = d.Name,
                            IsOn = d.IsOn,
                            Type = d.Type 
                          })

                         .Skip((pageNumber - 1) * pageSize)
                         .Take(pageSize)
                         .ToListAsync();
        }
        public async Task<DeviceResponseDto?> GetById(int id)
        {
            var device = await _context.Devices.FirstOrDefaultAsync(d => d.ID == id);

            if (device == null)
            {
                return null;
            }
            return new DeviceResponseDto 
            { 
                Id = device.ID,
                Name = device.Name,
                IsOn = device.IsOn,
                Type = device.Type 
            };
        }
        public async Task<DeviceResponseDto> Add(SmartDevice device)
        {
            _context.Devices.Add(device);
            await _context.SaveChangesAsync();

            return new DeviceResponseDto
            {
                Id = device.ID,
                Name = device.Name,
                IsOn = device.IsOn,
                Type = device.Type
            };
        }
        public async Task<bool> Update(int id, SmartDevice updatedDevice)
        {
            var up_device = await _context.Devices.FirstOrDefaultAsync(d => d.ID == id);
            if (up_device == null)
                return false;

            up_device.Name = updatedDevice.Name;
            up_device.IsOn = updatedDevice.IsOn;
            up_device.Type = updatedDevice.Type;

            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> Delete(int id)
        {
            var device_d = await _context.Devices.FirstOrDefaultAsync(del => del.ID == id);
            if (device_d == null)
                return false;

            _context.Devices.Remove(device_d);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Dictionary<DeviceType, int>> GetStats()
        {
            return await _context.Devices
                   .GroupBy(st => st.Type)
                   .Select(g => new { Key = g.Key, Count = g.Count() })
                   .ToDictionaryAsync(g => g.Key, g => g.Count);
        }
    }
}
