using SmartHome.API.Models;
using System.ComponentModel.DataAnnotations;

namespace SmartHome.API.DTOs
{
    public class CreateDeviceDto
    {
        public string Name { get; set; } = string.Empty;
        public bool IsOn { get; set; }
        public DeviceType Type { get; set; }
    }
}
