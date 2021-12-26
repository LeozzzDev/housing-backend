using Housing.Domain.DTOs;

namespace Housing.Domain.RepositoryInterfaces
{
    public interface IPropertiesRepository
    {
        IEnumerable<PropertyDTO> GetProperties();
        PropertyDTO GetPropertyById(string id);
        PropertyDTO CreateProperty(PropertyDTO property);
    }
}