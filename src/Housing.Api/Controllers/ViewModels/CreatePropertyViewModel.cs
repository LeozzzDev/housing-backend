using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Housing.Api.Controllers.ViewModels;

public class CreatePropertyViewModel
{
    public string Name { get; set; }
    public string Type { get; set; }
    public double Price { get; set; }

    public PropertyDTO ToDTO(this CreatePropertyViewModel viewModel)
    {
        return new PropertyDTO
        {
            Name = viewModel.Name,
            Type = viewModel.Type,
            Price = viewModel.Price
        };
    }
}