using SmartHome.API.Models;

namespace SmartHome.API.Services
{
    public interface IDeviceService
    {
        Task<List<SmartDevice>> GetAll(bool? isOn, bool? sortByAlphabet, DeviceType? type, string? searchQuery, int pageNumber, int pageSize);
        Task<SmartDevice?> GetById(int id);
        Task<SmartDevice> Add(SmartDevice device);
        Task<bool> Update(int id, SmartDevice device);
        Task<bool> Delete(int id);
        Task<Dictionary<DeviceType, int>> GetStats();
    }
}
