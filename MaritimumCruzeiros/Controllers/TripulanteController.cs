using MaritimumCruzeiros.Models;
using MaritimumCruzeiros.Models.DTOs;
using MaritimumCruzeiros.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CruzeirosEmporio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripulanteController : ControllerBase
    {
        private readonly ITripulanteService _tripulanteService;
        public TripulanteController(ITripulanteService service) 
        {
            _tripulanteService = service;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<Tripulante>?>> GetAll()
        {
            var tripulantes = await _tripulanteService.GetAll();
            return Ok(tripulantes);
        }

        [HttpGet("GetById")]
        public async Task<ActionResult<Tripulante?>> GetById(int id)
        {
            var tripulante = await _tripulanteService.GetById(id);
            return tripulante;
        }

        [HttpPost("CreateOrUpdate")]
        public async Task<ActionResult<Tripulante>> CreateOrUpdate([FromBody] TripulanteDTO tripulanteDTO)
        {
            var tripulante = _tripulanteService.ConvertDTO(tripulanteDTO);

            if (await _tripulanteService.CreateOrUpdate(tripulante) == true)
                return Ok(tripulante);

            return BadRequest();
        }

        [HttpDelete("Delete")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var res = await _tripulanteService.Delete(id);

            if(res == false) return BadRequest(false);

            return Ok(res);

        }
        
    }
}
