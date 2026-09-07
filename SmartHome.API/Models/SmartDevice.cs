namespace SmartHome.API.Models
{
    public class SmartDevice
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsOn { get; set; }
    }
}
