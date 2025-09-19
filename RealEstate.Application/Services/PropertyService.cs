using RealEstate.Application.Interfaces;
using RealEstate.Domain;

namespace RealEstate.Application.Services;

public class PropertyService
{
    private readonly IPropertyRepository _repository;

    public PropertyService(IPropertyRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Property>> GetAllPropertiesAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<Property?> GetPropertyByIdAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task<Property> CreatePropertyAsync(Property property)
    {
        return await _repository.CreateAsync(property);
    }

    public async Task<Property> UpdatePropertyAsync(Property property)
    {
        return await _repository.UpdateAsync(property);
    }

    public async Task DeletePropertyAsync(int id)
    {
        await _repository.DeleteAsync(id);
    }
}
