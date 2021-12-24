using Housing.Domain.DTOs;
using Housing.Domain.RepositoryInterfaces;

namespace Housing.Domain.Services;

public class HousingService
{
    private readonly IPropertiesRepository _repository;

    public HousingService(IPropertiesRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<PropertyDTO>> GetProperties()
    {
        var properties = await _repository.GetProperties();
        return properties;
    }
}