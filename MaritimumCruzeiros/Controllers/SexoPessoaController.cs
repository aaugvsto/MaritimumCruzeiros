using MaritimumCruzeiros.Models.DTOs;
using MaritimumCruzeiros.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MaritimumCruzeiros.Services.Interfaces;

namespace MaritimumCruzeiros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SexoPessoaController : ControllerBase
    {
        private readonly ISexoPessoaService _sexoPessoaService;

        public SexoPessoaController(ISexoPessoaService sexoPessoaService) 
        { 
            _sexoPessoaService = sexoPessoaService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ICollection<SexoPessoa>?>> GetAll()
        {
            var sexos = await _sexoPessoaService.GetAll();

            if (sexos != null)
                return Ok(sexos);

            return NotFound();
        }

        [HttpGet("GetById")]
        public async Task<ActionResult<SexoPessoa?>> GetById(int id)
        {
            var sexo = await _sexoPessoaService.GetById(id);

            if (sexo != null)
                return Ok(sexo);

            return NotFound(null);
        }

        [HttpPost("CreateOrUpdate")]
        public async Task<ActionResult<bool>> CreateOrUpdate([FromBody] SexoPessoaDTO sexoPessoaDTO)
        {
            var sexoPessoa = _sexoPessoaService.ConvertDTO(sexoPessoaDTO);
            var res = await _sexoPessoaService.CreateOrUpdate(sexoPessoa);

            if (res)
                return Ok(res);

            return BadRequest(res);
        }

        [HttpDelete("Delete")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var res = await _sexoPessoaService.Delete(id);

            if (!res)
                return BadRequest(false);

            return Ok(res);
        }
    }
}
