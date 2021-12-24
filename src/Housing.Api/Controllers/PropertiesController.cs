using Housing.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Housing.Api.Controllers;

[ApiController]
[Route("api/properties")]
public class PropertiesController : ControllerBase
{
    private readonly HousingService _service;

    public PropertiesController(HousingService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetProperties()
    {
        var properties = _service.GetProperties();
        return Ok(properties);
    }
}