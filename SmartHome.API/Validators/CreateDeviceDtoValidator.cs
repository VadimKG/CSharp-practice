using FluentValidation;
using SmartHome.API.DTOs;

namespace SmartHome.API.Validators
{
    public class CreateDeviceDtoValidator : AbstractValidator<CreateDeviceDto>
    {
        public CreateDeviceDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("The device name is required")
                .Length(3, 30).WithMessage("The name must contain between 3 and 30 characters.");
        }
    }
}
