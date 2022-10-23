using dotnetAPI.Models.Domain;

namespace dotnetAPI.Repositories
{
    public interface IRegionRepository
    {
        Task<IEnumerable<Region>>GetAllAsync();
    }
}
