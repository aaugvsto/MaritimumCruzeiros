using MaritimumCruzeiros.Models.DTOs;
using MaritimumCruzeiros.Models;
using MaritimumCruzeiros.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaritimumCruzeiros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransacaoController : ControllerBase
    {
        private readonly ITransacaoService _transacaoService;

        public TransacaoController(ITransacaoService transacaoService)
        {
            _transacaoService = transacaoService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ICollection<Transacao>?>> GetAll()
        {
            var cabines = await _transacaoService.GetAll();

            if (cabines != null)
                return Ok(cabines);

            return NotFound();

        }

        [HttpGet("GetById")]
        public async Task<ActionResult<Transacao?>> GetById(int id)
        {
            var transacao = await _transacaoService.GetById(id);

            if (transacao != null)
                return Ok(transacao);

            return NotFound(null);
        }

        [HttpGet("GetByEmail")]
        public async Task<ActionResult<Transacao?>> GetByEmail(string email)
        {
            var transacao = await _transacaoService.GetByEmail(email);

            if (transacao != null)
                return Ok(transacao);

            return NotFound(null);
        }

        [HttpPost("CreateOrUpdate")]
        public async Task<ActionResult<bool>> CreateOrUpdate([FromBody] TransacaoDTO transacaoDTO)
        {
            var transacao = _transacaoService.ConvertDTO(transacaoDTO);
            var res = await _transacaoService.CreateOrUpdate(transacao);

            if (res)
                return Ok(res);

            return BadRequest(res);
        }

        [HttpDelete("Delete")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var res = await _transacaoService.Delete(id);

            if (!res)
                return BadRequest(false);

            return Ok(res);
        }
    }
}
