using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SmartHome.API.Models;

namespace SmartHome.API.Services
{
    public class DeviceService : IDeviceService
    {
        private static List<SmartDevice> _devices = new List<SmartDevice>()
        {
            new SmartDevice { ID = 1, Name = "Xiaomi Lamp", IsOn = false, Type = DeviceType.Lamp },
            new SmartDevice { ID = 2, Name = "Apple Lamp", IsOn = true, Type = DeviceType.Lamp },
            new SmartDevice { ID = 3, Name = "Samsung Camera", IsOn = false, Type = DeviceType.Camera },
            new SmartDevice { ID = 4, Name = "Philips Speaker", IsOn = true, Type = DeviceType.Speaker }
        };

        public async Task<List<SmartDevice>> GetAll(bool? isOn, bool? sortByAlphabet, DeviceType? type, int pageNumber, int pageSize)
        {
            IEnumerable<SmartDevice> result = _devices;

            if (isOn != null)
            {
                result = result.Where(d => d.IsOn == isOn);
            }

            if(sortByAlphabet == true)
            {
                result = result.OrderBy(fa => fa.Name);
            }

            if (type != null)
            {
                result = result.Where(t => t.Type == type);
            }

            return await Task.FromResult(result.Skip((pageNumber - 1) * pageSize)
                         .Take(pageSize)
                         .ToList());
        }
        public async Task<SmartDevice?> GetById(int id)
        {
            return await Task.FromResult(_devices.FirstOrDefault(d => d.ID == id));
        }
        public async Task<SmartDevice> Add(SmartDevice device)
        {
            if (_devices.Count == 0)
            {
                device.ID = 1;
            }
            else
            {
                device.ID = _devices.Max(d => d.ID) + 1;    
            }
            _devices.Add(device);
            return await Task.FromResult(device);
        }
        public async Task<bool> Update(int id, SmartDevice updatedDevice)
        {
            var up_device = _devices.FirstOrDefault(d => d.ID == id);
            if (up_device == null)
                return await Task.FromResult(false);

            up_device.Name = updatedDevice.Name;
            up_device.IsOn = updatedDevice.IsOn;
            up_device.Type = updatedDevice.Type;

            return await Task.FromResult(true);
        }
        public async Task<bool> Delete(int id)
        {
            var device_d = _devices.FirstOrDefault(del => del.ID == id);
            if (device_d == null)
                return await Task.FromResult(false);

            _devices.Remove(device_d);

            return await Task.FromResult(true);
        }

        public async Task<Dictionary<DeviceType, int>> GetStats()
        {
            var st_device = _devices.GroupBy(st => st.Type);
            return await Task.FromResult(st_device.ToDictionary(g => g.Key, g => g.Count()));
        }
    }
}
