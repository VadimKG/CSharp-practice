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
        public async Task<ActionResult<IEnumerable<DeviceResponseDto>>> GetList(bool? isOn, bool? sortByAlphabet, DeviceType? type, string? searchQuery, int pageNumber = 1, int pageSize = 10)
        {
            return Ok(await _deviceService.GetAll(isOn, sortByAlphabet, type, searchQuery, pageNumber, pageSize)); 
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SmartDevice>> GetDevice(int id)
        {
            var device = await _deviceService.GetById(id);
            if (device == null)
                return NotFound();

            return Ok(device);
        }

        [HttpGet("stats")]
        public async Task<ActionResult<Dictionary<DeviceType, int>>> GetStats()
        {
            var st_device = await _deviceService.GetStats();
            return Ok(st_device);
        }

        [HttpPost]
        public async Task<ActionResult> AddDevice(CreateDeviceDto dto)
        {
            var newDevice = new SmartDevice { Name = dto.Name, IsOn = dto.IsOn, Type = dto.Type };
            var createdDevice = await _deviceService.Add(newDevice);
            return Created("", createdDevice);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateDevice(int id, UpdateDeviceDto dto)
        {
            var newDevice = new SmartDevice { Name = dto.Name, IsOn = dto.IsOn, Type = dto.Type };
            var updated = await _deviceService.Update(id, newDevice);
            if (!updated)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteDevice(int id)
        {
            var deleted = await _deviceService.Delete(id);
            if (!deleted)
                return NotFound();

            return NoContent();
        }
    }

}
