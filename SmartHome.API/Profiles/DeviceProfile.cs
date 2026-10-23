using AutoMapper;
using SmartHome.API.DTOs;
using SmartHome.API.Models;

namespace SmartHome.API.Profiles
{
    public class DeviceProfile : Profile
    {
        public DeviceProfile()
        {
            CreateMap<SmartDevice, DeviceResponseDto>();
            CreateMap<CreateDeviceDto, SmartDevice>();
        }
    }
}