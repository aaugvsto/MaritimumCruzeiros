using MaritimumCruzeiros.Models.DTOs;
using MaritimumCruzeiros.Models;
using MaritimumCruzeiros.Services;
using MaritimumCruzeiros.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CruzeirosEmporio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NavioController : ControllerBase
    {
        private readonly INavioService _navioService;

        public NavioController(INavioService navioService) 
        {
            _navioService = navioService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ICollection<Navio>?>> GetAll()
        {
            var navios = await _navioService.GetAll();

            if (navios != null)
                return Ok(navios);

            if(navios == null)
                return NotFound();

            return BadRequest();

        }

        [HttpGet("GetById")]
        public async Task<ActionResult<Navio?>> GetById(int id)
        {
            var navio = await _navioService.GetById(id);

            if (navio != null)
                return Ok(navio);

            return NotFound(null);
        }

        [HttpPost("CreateOrUpdate")]
        public async Task<ActionResult<bool>> CreateOrUpdate([FromBody] NavioDTO navioDTO)
        {
            var navio = _navioService.ConvertDTO(navioDTO);
            var res = await _navioService.CreateOrUpdate(navio);

            if (res)
                return Ok(res);

            return BadRequest(res);
        }

        [HttpDelete("Delete")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var res = await _navioService.Delete(id);

            if (!res)
                return BadRequest(false);

            return Ok(res);
        }

    }
}
