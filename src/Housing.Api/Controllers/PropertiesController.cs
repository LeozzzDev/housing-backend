using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Housing.Api.Controllers;

[ApiController]
[Route("api/properties")]
public class PropertiesController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetProperties()
    {
        return Ok("Hello");
    }

    [HttpPost]
    public async Task<IActionResult> CreateProperty(CreatePropertyViewModel createPropertyViewModel)
    {
        
    }
}