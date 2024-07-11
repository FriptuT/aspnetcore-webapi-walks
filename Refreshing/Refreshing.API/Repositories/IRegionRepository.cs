using Microsoft.AspNetCore.Mvc;
using Refreshing.API.Models.Domain;

namespace Refreshing.API.Repositories
{
    // Repository Pattern benefits:
    // - Decoupling meaning that separates the data access layer from the rest of the app : easier to mantain and test
    // - Multiple data sources (switching): supporting multiple data sources wich allow the app to switch between diff data sources
    //   without affecting the app logic
    public interface IRegionRepository
    {
        Task<List<Region>> GetAllAsync();

        Task<Region?> GetByIdAsync(Guid id);

        Task<Region> CreateAsync(Region region);

        Task<Region?> UpdateAsync(Guid id, Region region);

        Task<Region?> DeleteAsync(Guid id);
    }
}
