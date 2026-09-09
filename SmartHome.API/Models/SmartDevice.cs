using System.ComponentModel.DataAnnotations;

namespace SmartHome.API.Models
{
    public class SmartDevice
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "The device name is required!")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "The name must contain between 2 and 50 characters.")]
        public string Name { get; set; } = string.Empty;
        public bool IsOn { get; set; }
    }
}
