using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartHome.API.DTOs;
using SmartHome.API.Models;
using SmartHome.API.Repositories;

namespace SmartHome.API.Services
{
    public class DeviceService : IDeviceService
    {
        private readonly IDeviceRepository _repository;
        private readonly IMapper _mapper;

        public DeviceService(IDeviceRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<DeviceResponseDto>> GetAll(
                                                          bool? isOn, 
                                                          bool? sortByAlphabet, 
                                                          DeviceType? type, 
                                                          string? searchQuery, 
                                                          CancellationToken cancellationToken, 
                                                          int pageNumber, 
                                                          int pageSize)
        {
            var devices = await _repository.GetAllAsync(
                                                        isOn,
                                                        sortByAlphabet,
                                                        type,
                                                        searchQuery,
                                                        cancellationToken,
                                                        pageNumber,
                                                        pageSize);

            return _mapper.Map<List<DeviceResponseDto>>(devices);
        }
        public async Task<DeviceResponseDto?> GetById(int id, CancellationToken cancellationToken)
        {
            var device = await _repository.GetByIdAsync(id, cancellationToken);

            if (device == null)
            {
                return null;
            }
            return _mapper.Map<DeviceResponseDto>(device);
        }
        public async Task<DeviceResponseDto> Add(SmartDevice device, CancellationToken cancellationToken)
        {
            await _repository.AddAsync(device, cancellationToken);

            return _mapper.Map<DeviceResponseDto>(device);
        }
        public async Task<bool> Update(int id, SmartDevice updatedDevice, CancellationToken cancellationToken)
        {
            var up_device = await _repository.GetByIdAsync(id, cancellationToken);  
            if (up_device == null)
                return false;

            up_device.Name = updatedDevice.Name;
            up_device.IsOn = updatedDevice.IsOn;
            up_device.Type = updatedDevice.Type;

            await _repository.UpdateAsync(up_device, cancellationToken);
            return true;
        }
        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            var device_d = await _repository.GetByIdAsync(id, cancellationToken);
            if (device_d == null)
                return false;

            await _repository.DeleteAsync(device_d, cancellationToken);
            return true;
        }

        public async Task<Dictionary<DeviceType, int>> GetStats(CancellationToken cancellationToken)
        {
            return await _repository.GetStatsAsync(cancellationToken);
        }
    }
}
