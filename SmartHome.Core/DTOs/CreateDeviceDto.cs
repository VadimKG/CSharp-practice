using SmartHome.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace SmartHome.Core.DTOs;

public class CreateDeviceDto
{
    [Required]
    public string Name { get; set; } = string.Empty;
    public bool IsOn { get; set; }
    public DeviceType Type { get; set; }
}
