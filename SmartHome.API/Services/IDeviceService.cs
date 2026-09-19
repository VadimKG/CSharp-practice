using SmartHome.API.Models;

namespace SmartHome.API.Services
{
    public interface IDeviceService
    {
        List<SmartDevice> GetAll(bool? IsOn, bool? sortByAlphabet, int pageNumber, int pageSize);
        SmartDevice? GetById(int id);
        SmartDevice Add(SmartDevice device);
        bool Update(int id, SmartDevice device);
        bool Delete(int id);
    }
}
