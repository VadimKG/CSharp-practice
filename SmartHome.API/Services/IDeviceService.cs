using SmartHome.API.Models;

namespace SmartHome.API.Services
{
    public interface IDeviceService
    {
        List<SmartDevice> GetAll();
        SmartDevice? GetById(int id);
        SmartDevice Add(SmartDevice device);
        bool Update(int id, SmartDevice device);
        bool Delete(int id);
    }
}
