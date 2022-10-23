using AutoMapper;
using dotnetAPI.Models.DTO;
using dotnetAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace dotnetAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository _regionRepository;
        private readonly IMapper _mapper;

        public RegionsController(IRegionRepository regionRepository, IMapper mapper)
        {
            this._regionRepository = regionRepository;
            this._mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllRegions()
        {
            var regions = await _regionRepository.GetAllAsync();
            var regionsDTO = _mapper.Map<List<RegionDTO>>(regions);
            return Ok(regionsDTO);
        }


    }
}
