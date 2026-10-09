using SmartHome.API.DTOs;
using SmartHome.API.Models;

namespace SmartHome.API.Services
{
    public interface IDeviceService
    {
        Task<List<DeviceResponseDto>> GetAll(bool? isOn, bool? sortByAlphabet, DeviceType? type, string? searchQuery, int pageNumber, int pageSize);
        Task<DeviceResponseDto?> GetById(int id);
        Task<DeviceResponseDto> Add(SmartDevice device);
        Task<bool> Update(int id, SmartDevice device);
        Task<bool> Delete(int id);
        Task<Dictionary<DeviceType, int>> GetStats();
    }
}
