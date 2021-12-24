using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Housing.Infrastructure.Entities;

public class PropertyEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public double Price { get; set; }

    public PropertyDTO ToDTO(this PropertyEntity entity)
    {
        return new PropertyDTO
        {
            Name = viewModel.Name,
            Type = viewModel.Type,
            Price = viewModel.Price
        };
    }

}