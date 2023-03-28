using MaritimumCruzeiros.Models.DTOs;
using MaritimumCruzeiros.Models;
using MaritimumCruzeiros.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaritimumCruzeiros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoTripulanteController : ControllerBase
    {
        private readonly ITipoTripulanteService _tipoTripulanteService;

        public TipoTripulanteController(ITipoTripulanteService tipoCabineService)
        {
            _tipoTripulanteService = tipoCabineService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ICollection<TipoTripulante>?>> GetAll()
        {
            var tiposTripulante = await _tipoTripulanteService.GetAll();

            if (tiposTripulante != null)
                return Ok(tiposTripulante);

            return NotFound();
        }

        [HttpGet("GetById")]
        public async Task<ActionResult<TipoTripulante?>> GetById(int id)
        {
            var tipoTripulante = await _tipoTripulanteService.GetById(id);

            if (tipoTripulante != null)
                return Ok(tipoTripulante);

            return NotFound(null);
        }

        [HttpPost("CreateOrUpdate")]
        public async Task<ActionResult<bool>> CreateOrUpdate([FromBody] TipoTripulanteDTO tipoTripulanteDTO)
        {
            var tipoTripulante = _tipoTripulanteService.ConvertDTO(tipoTripulanteDTO);
            var res = await _tipoTripulanteService.CreateOrUpdate(tipoTripulante);

            if (res)
                return Ok(res);

            return BadRequest(res);
        }

        [HttpDelete("Delete")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var res = await _tipoTripulanteService.Delete(id);

            if (!res)
                return BadRequest(false);

            return Ok(res);
        }
    }
}
