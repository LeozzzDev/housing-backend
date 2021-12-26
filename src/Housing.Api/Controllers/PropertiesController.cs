using Housing.Api.Controllers.ViewModels;
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
    public ActionResult<PropertyDTO> GetProperty(string id)
    {
        var property = _service.GetPropertyById(id);

        if (property == null)
        {
            return NotFound();
        }

        return property;
    }

    [HttpPost]
    public ActionResult<PropertyDTO> CreateProperty(CreatePropertyViewModel request)
    {
        var property = _service.CreateProperty(request.ToDTO());
        return CreatedAtAction(nameof(GetProperty), new { Id = property.Id }, property);
    }
}