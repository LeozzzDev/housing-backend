using Housing.Domain.DTOs;

namespace Housing.Infrastructure.Entities;

public class PropertyEntity
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? Type { get; set; }
    public double Price { get; set; }
    public string? CreatedDate { get; set; }

    public PropertyDTO ToDTO()
    {
        return new PropertyDTO
        {
            Id = Id,
            Name = Name ?? "",
            Type = Type ?? "",
            Price = Price
        };
    }
}