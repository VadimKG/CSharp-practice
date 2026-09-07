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



    }

}
