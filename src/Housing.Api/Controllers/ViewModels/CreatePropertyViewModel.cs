using Housing.Domain.DTOs;

namespace Housing.Api.Controllers.ViewModels;

public class CreatePropertyViewModel
{
    public string? Name { get; set; }
    public string? Type { get; set; }
    public double Price { get; set; }

    public PropertyDTO ToDTO()
    {
        return new PropertyDTO
        {
            Name = Name ?? "",
            Type = Type ?? "",
            Price = Price
        };
    }
}