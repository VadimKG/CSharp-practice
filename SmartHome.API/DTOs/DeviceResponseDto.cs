using SmartHome.API.Models;

namespace SmartHome.API.DTOs
{
    public class DeviceResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsOn { get; set; }
        public DeviceType Type { get; set; }
    }
}
