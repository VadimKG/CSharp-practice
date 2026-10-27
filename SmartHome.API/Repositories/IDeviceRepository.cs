using SmartHome.API.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace SmartHome.API.Repositories
{
    public interface IDeviceRepository
    {
        Task<List<SmartDevice>> GetAllAsync(
                                            bool? isOn,
                                            bool? sortByAlphabet,
                                            DeviceType? type,
                                            string? searchQuery,
                                            CancellationToken cancellationToken,
                                            int pageNumber,
                                            int pageSize);
        Task<SmartDevice?> GetByIdAsync(int id, CancellationToken cancellationToken);
        Task AddAsync(SmartDevice device, CancellationToken cancellationToken);
        Task UpdateAsync(SmartDevice device, CancellationToken cancellationToken);
        Task DeleteAsync(SmartDevice device, CancellationToken cancellationToken);
        Task<Dictionary<DeviceType, int>> GetStatsAsync(CancellationToken cancellationToken);
    }
}
