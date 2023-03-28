using MaritimumCruzeiros.Models.DTOs;
using MaritimumCruzeiros.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MaritimumCruzeiros.Services.Interfaces;

namespace MaritimumCruzeiros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CabineTripulanteController : ControllerBase
    {
        private readonly ICabineTripulanteService _cabineTripulanteService;

        public CabineTripulanteController(ICabineTripulanteService cabineTripulanteService)
        {
            _cabineTripulanteService = cabineTripulanteService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ICollection<Cabine>?>> GetAll()
        {
            var cabines = await _cabineTripulanteService.GetAll();

            if (cabines != null)
                return Ok(cabines);

            return NotFound();

        }

        [HttpGet("GetById")]
        public async Task<ActionResult<Cabine?>> GetById(int id)
        {
            var cabine = await _cabineTripulanteService.GetById(id);

            if (cabine != null)
                return Ok(cabine);

            return NotFound(null);
        }

        [HttpPost("CreateOrUpdate")]
        public async Task<ActionResult<bool>> CreateOrUpdate([FromBody] CabineTripulanteDTO cabineTripulanteDTO)
        {
            var cabine = _cabineTripulanteService.ConvertDTO(cabineTripulanteDTO);
            var res = await _cabineTripulanteService.CreateOrUpdate(cabine);

            if (res)
                return Ok(res);

            return BadRequest(res);
        }

        [HttpDelete("Delete")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var res = await _cabineTripulanteService.Delete(id);

            if (!res)
                return BadRequest(false);

            return Ok(res);
        }
    }
}
