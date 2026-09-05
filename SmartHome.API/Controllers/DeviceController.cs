using Microsoft.AspNetCore.Mvc;

namespace SmartHome.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]  
    public class DeviceController : ControllerBase
    {
        [HttpGet]
        public string GetString()
        {
            return "Server is running!";
        }
    }
}
