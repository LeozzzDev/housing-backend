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
                Price = 120.00,
                CreatedDate = DateTime.UtcNow.ToString("YYYY-MM-ddTHH:mm:ss")
            },
            new PropertyEntity
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Foo House",
                Type = "Ville",
                Price = 300000,
                CreatedDate = DateTime.UtcNow.ToString("YYYY-MM-ddTHH:mm:ss")
            },
            new PropertyEntity
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Pluto House",
                Type = "Little",
                Price = 200.00,
                CreatedDate = DateTime.UtcNow.ToString("YYYY-MM-ddTHH:mm:ss")
            },
            new PropertyEntity
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Mickey House",
                Type = "Big",
                Price = 200.00,
                CreatedDate = DateTime.UtcNow.ToString("YYYY-MM-ddTHH:mm:ss"),
            },
        };
    }

    public IEnumerable<PropertyDTO> GetProperties()
    {
        var propertiesDtos = _properties
            .Select(entity => entity.ToDTO());

        return propertiesDtos;
    }

    public PropertyDTO GetPropertyById(string id)
    {
        var property = _properties
            .Where(property => property.Id == id).FirstOrDefault();

        return property == null ? null : property.ToDTO();
    }

    public PropertyDTO CreateProperty(PropertyDTO property)
    {
        var propertyEntity = new PropertyEntity
        {
            Id = Guid.NewGuid().ToString(),
            Name = property.Name,
            Type = property.Type,
            Price = property.Price,
            CreatedDate = DateTime.UtcNow.ToString("YYYY-MM-ddTHH:mm:ss"),
        };
        
        _properties.Add(propertyEntity);
        return propertyEntity.ToDTO();
    }
}