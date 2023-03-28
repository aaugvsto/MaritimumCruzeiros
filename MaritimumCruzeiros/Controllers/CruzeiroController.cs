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
    public class CruzeiroController : ControllerBase
    {
        private readonly ICruzeiroService _cruzeiroService;

        public CruzeiroController (ICruzeiroService cruzeiroService)
        {
            _cruzeiroService = cruzeiroService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ICollection<Cruzeiro>?>> GetAll()
        {
            var cruzeiros = await _cruzeiroService.GetAll();

            if (cruzeiros != null)
                return Ok(cruzeiros);

            return NotFound();

        }

        [HttpGet("GetById")]
        public async Task<ActionResult<Cruzeiro?>> GetById(int id)
        {
            var cruzeiro = await _cruzeiroService.GetById(id);

            if (cruzeiro != null)
                return Ok(cruzeiro);

            return NotFound(null);
        }

        [HttpPost("CreateOrUpdate")]
        public async Task<ActionResult<bool>> CreateOrUpdate([FromBody] CruzeiroDTO cruzeiroDTO)
        {
            var cruzeiro = _cruzeiroService.ConvertDTO(cruzeiroDTO);
            var res = await _cruzeiroService.CreateOrUpdate(cruzeiro);

            if (res)
                return Ok(res);

            return BadRequest(res);
        }

        [HttpDelete("Remove")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var res = await _cruzeiroService.Delete(id);

            if (!res)
                return BadRequest(false);

            return Ok(res);
        }
    }
}
