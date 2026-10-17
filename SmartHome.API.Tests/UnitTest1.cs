using SmartHome.API.DTOs;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace SmartHome.API.Tests;

public class DeviceValidationTests
{
    [Fact]
    public void CreateDeviceDto_WithoutName_ShouldBeInvalid()
    {
        // Arrange
        var dto = new CreateDeviceDto { Name = "", IsOn = true };
        var context = new ValidationContext(dto);
        var results = new List<ValidationResult>();

        // Act
        bool isValid = Validator.TryValidateObject(dto, context, results, true);

        // Assert
        Assert.False(isValid);
    }
}   