using Housing.Domain.DTOs;

namespace Housing.Domain.RepositoryInterfaces
{
    public interface IPropertiesRepository
    {
        IEnumerable<PropertyDTO> GetProperties();
        PropertyDTO GetPropertiesById(string id);
    }
}