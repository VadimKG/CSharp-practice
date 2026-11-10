using SmartHome.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace SmartHome.Core.DTOs
{
    public class UpdateDeviceDto
    {
        [Required(ErrorMessage = "The device name is required")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "The name must contain between 2 and 20 characters.")]

        public string Name { get; set; } = string.Empty;
        public bool IsOn { get; set; }
        public DeviceType Type { get; set; }
    }
}
