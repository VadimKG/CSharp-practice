using Microsoft.AspNetCore.Mvc;
using SmartHome.API.Models;

namespace SmartHome.API.Services
{
    public class DeviceService : IDeviceService
    {
        private static List<SmartDevice> _devices = new List<SmartDevice>()
        {
            new SmartDevice { ID = 1, Name = "Xiaomi Lamp", IsOn = false },
            new SmartDevice { ID = 2, Name = "Apple Lamp", IsOn = true }
        };

        public List<SmartDevice> GetAll()
        {
            return _devices;
        }
        public SmartDevice? GetById(int id)
        {
            return _devices.FirstOrDefault(d => d.ID == id);
        }
        public SmartDevice Add(SmartDevice device)
        {
            _devices.Add(device);
            return device;
        }
        public bool Update(int id, SmartDevice updatedDevice)
        {
            var up_device = _devices.FirstOrDefault(d => d.ID == id);
            if (up_device == null)
                return false;

            up_device.Name = updatedDevice.Name;
            up_device.IsOn = updatedDevice.IsOn;

            return true;
        }
        public bool Delete(int id)
        {
            var device_d = _devices.FirstOrDefault(del => del.ID == id);
            if (device_d == null)
                return false;

            _devices.Remove(device_d);

            return true;
        }
    }
}
