using AutoMapper;
using SmartHome.Core.DTOs;
using SmartHome.Core.Models;

namespace SmartHome.API.Profiles;

public class DeviceProfile : Profile
{
    public DeviceProfile()
    {
        CreateMap<SmartDevice, DeviceResponseDto>();
        CreateMap<CreateDeviceDto, SmartDevice>();
    }
}