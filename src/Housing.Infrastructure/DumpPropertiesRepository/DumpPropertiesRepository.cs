using Housing.Domain.DTOs;
using Housing.Domain.RepositoryInterfaces;
using Housing.Infrastructure.Entities;

namespace Housing.Infrastructure.DumpPropertiesRepository;

public class DumpPropertiesRepository : IPropertiesRepository
{
    private readonly List<PropertyEntity> _properties;

    public DumpPropertiesRepository()
    {
        _properties = new()
        {
            new PropertyEntity
            {
                Id = Guid.NewGuid().ToString(),
                Name = "LeoHouse",
                Type = "Familiar",
                CreatedDate = DateTime.UtcNow.ToString("YYYY-MM-ddTHH:mm:ss")
            },
            new PropertyEntity
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Foo House",
                Type = "Ville",
                CreatedDate = DateTime.UtcNow.ToString("YYYY-MM-ddTHH:mm:ss")
            },
            new PropertyEntity
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Pluto House",
                Type = "Little",
                CreatedDate = DateTime.UtcNow.ToString("YYYY-MM-ddTHH:mm:ss")
            },
            new PropertyEntity
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Mickey House",
                Type = "Big",
                CreatedDate = DateTime.UtcNow.ToString("YYYY-MM-ddTHH:mm:ss")
            },
        };
    }

    public async Task<IEnumerable<PropertyDTO>> GetProperties()
    {
        var propertiesDtos = _properties
            .Select(entity => entity.ToDTO());

        return await Task.FromResult(propertiesDtos);
    }
}