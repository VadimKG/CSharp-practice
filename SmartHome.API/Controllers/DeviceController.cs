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
        private readonly ILogger<DeviceController> _logger;

        public DeviceController(IDeviceService deviceService, ILogger<DeviceController> logger)
        {
            _deviceService = deviceService;
            _logger = logger;
        }
        

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DeviceResponseDto>>> GetList(bool? isOn, bool? sortByAlphabet, DeviceType? type, string? searchQuery, CancellationToken cancellationToken, int pageNumber = 1, int pageSize = 10)
        {
            return Ok(await _deviceService.GetAll(isOn, sortByAlphabet, type, searchQuery, cancellationToken, pageNumber, pageSize)); 
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DeviceResponseDto>> GetDevice(int id, CancellationToken cancellationToken)
        {
            var device = await _deviceService.GetById(id, cancellationToken);
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
        public async Task<ActionResult<DeviceResponseDto>> AddDevice(CreateDeviceDto dto, CancellationToken cancellationToken)
        {
                var newDevice = new SmartDevice { Name = dto.Name, IsOn = dto.IsOn, Type = dto.Type };
                var createdDevice = await _deviceService.Add(newDevice, cancellationToken);
                _logger.LogInformation("Device added successfully: {DeviceName}", newDevice.Name);
                return CreatedAtAction(nameof(GetDevice), new { id = createdDevice.Id }, createdDevice);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateDevice(int id, UpdateDeviceDto dto, CancellationToken cancellationToken)
        {
            var newDevice = new SmartDevice { Name = dto.Name, IsOn = dto.IsOn, Type = dto.Type };
            var updated = await _deviceService.Update(id, newDevice, cancellationToken);
            if (!updated)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteDevice(int id, CancellationToken cancellationToken)
        {
            var deleted = await _deviceService.Delete(id, cancellationToken);
            if (!deleted)
                return NotFound();

            _logger.LogInformation("Device with ID:  {Id}  has been deleted", id);
            return NoContent();
        }
    }

}
