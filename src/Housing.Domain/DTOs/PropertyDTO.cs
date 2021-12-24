using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Housing.Domain.DTOs;

public class PropertyDTO
{
    public string Name { get; set; }
    public string Type { get; set; }
    public double Price { get; set; }
}