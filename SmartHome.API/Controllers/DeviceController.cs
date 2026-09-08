using Microsoft.AspNetCore.Mvc;
using SmartHome.API.Models;

namespace SmartHome.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeviceController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<SmartDevice>> GetList()
        {
            return Ok(_devices);
        }

        [HttpGet("{id}")]
        public ActionResult<SmartDevice> GetDevice(int id)
        {
            var device = _devices.FirstOrDefault(d => d.ID == id);
            if (device == null)
                return NotFound();
            else
                return Ok(device);
        }

        private static List<SmartDevice> _devices = new List<SmartDevice>()
        {
            new SmartDevice { ID = 1, Name = "Xiaomi Lamp", IsOn = false },
            new SmartDevice { ID = 2, Name = "Apple Lamp", IsOn = true }
        };

        [HttpPost]
        public ActionResult AddDevice(SmartDevice newDevice)
        {
            _devices.Add(newDevice);
            return Created("", newDevice);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateDevice(int id, SmartDevice updatedDevice)
        {
            var up_device = _devices.FirstOrDefault(d => d.ID == id);
            if (up_device == null)
                return NotFound();

            up_device.Name = updatedDevice.Name;
            up_device.IsOn = updatedDevice.IsOn;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteDevice(int id)
        {
            var device_d = _devices.FirstOrDefault(del => del.ID == id);
            if (device_d == null)
                return NotFound();
            
            _devices.Remove(device_d);
            
            return NoContent();
        }
    }

}
