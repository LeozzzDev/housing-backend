using Housing.Domain.DTOs;

namespace Housing.Domain.RepositoryInterfaces
{
    public interface IPropertiesRepository
    {
        Task<IEnumerable<PropertyDTO>> GetProperties();   
    }
}