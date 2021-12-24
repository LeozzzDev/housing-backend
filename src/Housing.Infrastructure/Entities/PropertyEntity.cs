using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Housing.Domain.DTOs;

namespace Housing.Infrastructure.Entities;

public class PropertyEntity
{
    public Guid Id { get; set; }
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