using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Housing.Domain.DTOs;

namespace Housing.Api.Controllers.ViewModels;

public class CreatePropertyViewModel
{
    [Required]
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [Required]
    [JsonPropertyName("type")]
    public string Type { get; set; }
    [Required]
    [JsonPropertyName("price")]
    public double Price { get; set; }

    public PropertyDTO ToDTO()
    {
        return new PropertyDTO
        {
            Name = Name,
            Type = Type,
            Price = Price
        };
    }
}