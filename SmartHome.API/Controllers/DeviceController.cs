using Microsoft.AspNetCore.Mvc;
using SmartHome.API.Models;
using SmartHome.API.Services;
using SmartHome.API.DTOs;

namespace SmartHome.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeviceController : ControllerBase
    {
        private readonly IDeviceService _deviceService;
        public DeviceController(IDeviceService deviceService)
        {
            _deviceService = deviceService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<SmartDevice>> GetList()
        {
            return Ok(_deviceService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<SmartDevice> GetDevice(int id)
        {
            var device = _deviceService.GetById(id);
            if (device == null)
                return NotFound();

            return Ok(device);
        }

        [HttpPost]
        public ActionResult AddDevice(CreateDeviceDto dto)
        {
            var newDevice = new SmartDevice { Name = dto.Name, IsOn = dto.IsOn };
            var createdDevice = _deviceService.Add(newDevice);
            return Created("", createdDevice);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateDevice(int id, SmartDevice updatedDevice)
        {
            var updated = _deviceService.Update(id, updatedDevice);
            if (!updated)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteDevice(int id)
        {
            var deleted = _deviceService.Delete(id);
            if (!deleted)
                return NotFound();

            return NoContent();
        }
    }

}
