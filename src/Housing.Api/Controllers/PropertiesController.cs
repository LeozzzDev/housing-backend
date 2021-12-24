using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Housing.Api.Controllers.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Housing.Api.Controllers;

[ApiController]
[Route("api/properties")]
public class PropertiesController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetPropertiesAsync()
    {
        return await Task.FromResult(Ok("Getting Properties..."));
    }

    [HttpPost]
    public async Task<IActionResult> CreatePropertyAsync(CreatePropertyViewModel createPropertyViewModel)
    {
        return await Task.FromResult(Ok("Created New Property"));
    }
}