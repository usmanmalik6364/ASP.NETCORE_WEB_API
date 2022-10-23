using dotnetAPI.Data;
using dotnetAPI.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace dotnetAPI.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly NZWalksDbContext _nzWalksDbContext;
        public RegionRepository(NZWalksDbContext nZWalksDbContext)
        {
            this._nzWalksDbContext = nZWalksDbContext;

        }
        public async Task<IEnumerable<Region>> GetAllAsync()
        {

            return await _nzWalksDbContext.Regions.ToListAsync();
        }
    }
}
