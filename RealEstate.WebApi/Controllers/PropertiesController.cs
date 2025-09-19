using Microsoft.AspNetCore.Mvc;
using RealEstate.Application.Services;
using RealEstate.Domain;

namespace RealEstate.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PropertiesController : ControllerBase
{
    private readonly PropertyService _propertyService;

    public PropertiesController(PropertyService propertyService)
    {
        _propertyService = propertyService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Property>>> GetProperties()
    {
        var properties = await _propertyService.GetAllPropertiesAsync();
        return Ok(properties);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Property>> GetProperty(int id)
    {
        var property = await _propertyService.GetPropertyByIdAsync(id);
        if (property == null) return NotFound();
        return Ok(property);
    }

    [HttpPost]
    public async Task<ActionResult<Property>> CreateProperty(Property property)
    {
        var created = await _propertyService.CreatePropertyAsync(property);
        return CreatedAtAction(nameof(GetProperty), new { id = created.Id }, created);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProperty(int id, Property property)
    {
        if (id != property.Id) return BadRequest();
        await _propertyService.UpdatePropertyAsync(property);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProperty(int id)
    {
        await _propertyService.DeletePropertyAsync(id);
        return NoContent();
    }
}
