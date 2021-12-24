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

    public IEnumerable<PropertyDTO> GetProperties()
    {
        var properties = _repository.GetProperties();
        return properties;
    }
}