using MaritimumCruzeiros.Services.Interfaces;
using MaritimumCruzeiros.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MaritimumCruzeiros.Models.DTOs;

namespace MaritimumCruzeiros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaService _pessoaService;
        public PessoaController(IPessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ICollection<Pessoa>?>> GetAll()
        {
            var pessoas = await _pessoaService.GetAll();

            if (pessoas != null)
                return Ok(pessoas);

            return NotFound();

        }

        [HttpGet("GetById")]
        public async Task<ActionResult<Pessoa?>> GetById(int id)
        {
            var pessoa = await _pessoaService.GetById(id);
            
            if(pessoa != null)
                return Ok(pessoa);

            return NotFound(null);
        }

        [HttpGet("GetByEmail")]
        public async Task<ActionResult<Pessoa?>> GetByEmail(string email)
        {
            var pessoa = await _pessoaService.GetByEmail(email);

            if (pessoa != null)
                return Ok(pessoa);

            return NotFound(null);
        }

        [HttpGet("Login")]
        public async Task<ActionResult<Pessoa?>> Login(string email, string password)
        {
            var pessoa = await _pessoaService.Login(email, password);

            if (pessoa != null)
                return Ok(pessoa);

            return NotFound(null);
        }

        [HttpPost("CreateOrUpdate")]
        public async Task<ActionResult<bool>> CreateOrUpdate([FromBody] PessoaDTO pessoaDTO)
        {
            var pessoa = _pessoaService.ConvertDTO(pessoaDTO);
            var res = await _pessoaService.CreateOrUpdate(pessoa);

            if(res)
                return Ok(res);

            return BadRequest(res);
        }

        [HttpDelete("Delete")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var res = await _pessoaService.Delete(id);

            if (!res)
                return BadRequest(false);

            return Ok(res);
        }
    }
}
