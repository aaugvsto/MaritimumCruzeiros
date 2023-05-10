using MaritimumCruzeiros.Models.DTOs;
using MaritimumCruzeiros.Models;
using MaritimumCruzeiros.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MaritimumCruzeiros.Services;

namespace MaritimumCruzeiros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CupomController : ControllerBase
    {
        private readonly ICupomService _cupomService;

        public CupomController(ICupomService cupomService)
        {
            _cupomService = cupomService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ICollection<Cupom>?>> GetAll()
        {
            var cupons = await _cupomService.GetAll();

            if (cupons != null)
                return Ok(cupons);

            return NotFound();

        }

        [HttpGet("GetByCodigo")]
        public async Task<ActionResult<Cabine?>> GetByCodigo(string codigo)
        {
            var cupom = await _cupomService.GetByCodigo(codigo);

            if (cupom != null)
                return Ok(cupom);

            return NotFound(null);
        }

        [HttpGet("GetById")]
        public async Task<ActionResult<Cupom?>> GetById(int id)
        {
            var cabine = await _cupomService.GetById(id);

            if (cabine != null)
                return Ok(cabine);

            return NotFound(null);
        }

        [HttpPost("CreateOrUpdate")]
        public async Task<ActionResult<bool>> CreateOrUpdate([FromBody] CupomDTO cabineDTO)
        {
            var cabine = _cupomService.ConvertDTO(cabineDTO);
            var res = await _cupomService.CreateOrUpdate(cabine);

            if (res)
                return Ok(res);

            return BadRequest(res);
        }

        [HttpDelete("Delete")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var res = await _cupomService.Delete(id);

            if (!res)
                return BadRequest(false);

            return Ok(res);
        }
    }
}
