using AutoMapper;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.OpenApi;
using Moq;
using SmartHome.API.DTOs;
using SmartHome.API.Models;
using SmartHome.API.Repositories;
using SmartHome.API.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SmartHome.API.Tests;

public class DeviceServiceTests
{
    [Fact]
    public async Task GetAll_ReturnsListOfDevices()
    {
        // Arrange
        var mockCache = new Mock<IMemoryCache>();
        var mockRepository = new Mock<IDeviceRepository>();
        var mockMapper = new Mock<IMapper>();

        var fakeDevices = new List<SmartDevice>
        {
            new SmartDevice { ID = 1, Name = "Device1", IsOn = true }
        };

        var fakeResponseDtos = new List<DeviceResponseDto>
        {
            new DeviceResponseDto { Id = 1, Name = "Device1", IsOn = true }
        };

        mockRepository.Setup(repo => repo.GetAllAsync(
        It.IsAny<bool?>(),
        It.IsAny<bool?>(),
        It.IsAny<DeviceType?>(),
        It.IsAny<string?>(),
        It.IsAny<CancellationToken>(),
        It.IsAny<int>(),
        It.IsAny<int>()))
            .ReturnsAsync(fakeDevices);

        mockMapper.Setup(m => m.Map<List<DeviceResponseDto>>(fakeDevices))
            .Returns(fakeResponseDtos);

        var service = new DeviceService(mockCache.Object, mockRepository.Object, mockMapper.Object);
        
        // Act
        var result = await service.GetAll(null, null, null, null, CancellationToken.None, 1, 10);

        // Assert
        Assert.NotNull(result); 
        Assert.Single(result);
    }

    [Fact]
    public async Task Add_CallsRepositoryAddMethod_ExactlyOnce()
    {
        // Arrange 
        var mockCache = new Mock<IMemoryCache>();
        var mockRepository = new Mock<IDeviceRepository>();
        var mockMapper = new Mock<IMapper>();

        var service = new DeviceService(mockCache.Object, mockRepository.Object, mockMapper.Object);
        var fakeDevice = new SmartDevice { ID = 1, Name = "The Lamp", IsOn = true };

        // Act
        var result = await service.Add(fakeDevice, CancellationToken.None);

        // Assert
        mockRepository.Verify(r => r.AddAsync(It.IsAny<SmartDevice>(), It.IsAny<CancellationToken>()), Times.Once);
    }
}
