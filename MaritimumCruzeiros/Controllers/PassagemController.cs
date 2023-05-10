using MaritimumCruzeiros.Models.DTOs;
using MaritimumCruzeiros.Models;
using MaritimumCruzeiros.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaritimumCruzeiros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassagemController : ControllerBase
    {
        private readonly IPassagemService _passagemService;

        public PassagemController(IPassagemService passagemService)
        {
            _passagemService = passagemService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ICollection<Passagem>?>> GetAll()
        {
            var passagens = await _passagemService.GetAll();

            if (passagens != null)
                return Ok(passagens);

            return NotFound();

        }

        [HttpGet("GetById")]
        public async Task<ActionResult<Passagem?>> GetById(int id)
        {
            var passagem = await _passagemService.GetById(id);

            if (passagem != null)
                return Ok(passagem);

            return NotFound(null);
        }

        [HttpPost("CreateOrUpdate")]
        public async Task<ActionResult<bool>> CreateOrUpdate([FromBody] PassagemDTO passagemDTO)
        {
            var passagem = _passagemService.ConvertDTO(passagemDTO);
            var res = await _passagemService.CreateOrUpdate(passagem);

            if (res)
                return Ok(res);

            return BadRequest(res);
        }

        [HttpDelete("Delete")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var res = await _passagemService.Delete(id);

            if (!res)
                return BadRequest(false);

            return Ok(res);
        }
    }
}

