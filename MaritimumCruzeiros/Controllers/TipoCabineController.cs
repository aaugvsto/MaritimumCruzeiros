using MaritimumCruzeiros.Models.DTOs;
using MaritimumCruzeiros.Models;
using MaritimumCruzeiros.Services;
using MaritimumCruzeiros.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace MaritimumCruzeiros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoCabineController : ControllerBase
    {
        private readonly ITipoCabineService _tipoCabineService;

        public TipoCabineController(ITipoCabineService tipoCabineService)
        {
            _tipoCabineService = tipoCabineService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ICollection<TipoCabine>?>> GetAll()
        {
            var tiposCabines = await _tipoCabineService.GetAll();

            if (tiposCabines != null)
                return Ok(tiposCabines);

            return NotFound();

        }

        [HttpGet("GetById")]
        public async Task<ActionResult<TipoCabine?>> GetById(int id)
        {
            var tipoCabine = await _tipoCabineService.GetById(id);

            if (tipoCabine != null)
                return Ok(tipoCabine);

            return NotFound(null);
        }

        [HttpPost("CreateOrUpdate")]
        public async Task<ActionResult<bool>> CreateOrUpdate([FromBody] TipoCabineDTO tipoCabineDTO)
        {
            var tipoCabine = _tipoCabineService.ConvertDTO(tipoCabineDTO);
            var res = await _tipoCabineService.CreateOrUpdate(tipoCabine);

            if (res)
                return Ok(res);

            return BadRequest(res);
        }

        [HttpDelete("Delete")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var res = await _tipoCabineService.Delete(id);

            if (!res)
                return BadRequest(false);

            return Ok(res);
        }
    }
}
