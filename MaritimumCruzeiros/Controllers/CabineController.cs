using MaritimumCruzeiros.Models.DTOs;
using MaritimumCruzeiros.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MaritimumCruzeiros.Services.Interfaces;

namespace MaritimumCruzeiros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CabineController : ControllerBase
    {
        private readonly ICabineService _cabineService;

        public CabineController(ICabineService cabineService)
        {
            _cabineService = cabineService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ICollection<Cabine>?>> GetAll()
        {
            var cabines = await _cabineService.GetAll();

            if (cabines != null)
                return Ok(cabines);

            return NotFound();

        }

        [HttpGet("GetById")]
        public async Task<ActionResult<Cabine?>> GetById(int id)
        {
            var cabine = await _cabineService.GetById(id);

            if (cabine != null)
                return Ok(cabine);

            return NotFound(null);
        }

        [HttpPost("CreateOrUpdate")]
        public async Task<ActionResult<bool>> CreateOrUpdate([FromBody] CabineDTO cabineDTO)
        {
            var cabine = _cabineService.ConvertDTO(cabineDTO);
            var res = await _cabineService.CreateOrUpdate(cabine);

            if (res)
                return Ok(res);

            return BadRequest(res);
        }

        [HttpDelete("Delete")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var res = await _cabineService.Delete(id);

            if (!res)
                return BadRequest(false);

            return Ok(res);
        }
    }
}
