using SmartHome.API.DTOs;
using SmartHome.API.Models;

namespace SmartHome.API.Services
{
    public interface IDeviceService
    {
        Task<List<DeviceResponseDto>> GetAll(
            bool? isOn,
            bool? sortByAlphabet,
            DeviceType? type,
            string? searchQuery,
            CancellationToken cancellationToken,
            int pageNumber,
            int pageSize);
        Task<DeviceResponseDto?> GetById(int id, CancellationToken cancellationToken);
        Task<DeviceResponseDto> Add(SmartDevice device, CancellationToken cancellationToken);
        Task<bool> Update(int id, SmartDevice device, CancellationToken cancellationToken);
        Task<bool> Delete(int id, CancellationToken cancellationToken);
        Task<Dictionary<DeviceType, int>> GetStats();
    }
}
