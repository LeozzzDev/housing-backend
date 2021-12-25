using Housing.Domain.DTOs;
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
    public IEnumerable<PropertyDTO> GetProperties()
    {
        var properties = _service.GetProperties();
        return properties;
    }

    [HttpGet("{id}")]
    public ActionResult<PropertyDTO> GetProperties(string id)
    {
        var property = _service.GetPropertiesById(id);

        if (property == null)
        {
            return NotFound();
        }

        return property;
    }
}