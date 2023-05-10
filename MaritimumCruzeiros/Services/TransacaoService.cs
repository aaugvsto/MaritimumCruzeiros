using MaritimumCruzeiros.Data;
using MaritimumCruzeiros.Models;
using MaritimumCruzeiros.Models.DTOs;
using MaritimumCruzeiros.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MaritimumCruzeiros.Services
{
    public class TransacaoService : ITransacaoService
    {
        private readonly DBContext _dbContext;

        public TransacaoService(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Transacao ConvertDTO(TransacaoDTO transacaoDTO)
        {
            return new Transacao()
            {
                Id = transacaoDTO.Id == 0 ? null : transacaoDTO.Id,
                EmailCliente = transacaoDTO.EmailCliente,
                NumeroParcelas = transacaoDTO.NumeroParcelas,
                NumerosFinaisCartao = transacaoDTO.NumerosFinaisCartao,
                Resultado = transacaoDTO.Resultado,
                TipoCartao = transacaoDTO.TipoCartao,
                ValorTotal = transacaoDTO.ValorTotal
            };
        }

        public async Task<bool> CreateOrUpdate(Transacao transacao)
        {
            try
            {
                await _dbContext.Transacoes.AddAsync(transacao);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                var transacao = await GetById(id);
                if(transacao != null) 
                {
                    _dbContext.Transacoes.Remove(transacao);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public async Task<ICollection<Transacao>?> GetAll()
        {
            try
            {
                return await _dbContext.Transacoes.ToListAsync();
            }
            catch
            {
                return null;
            }

        }

        public async Task<Transacao?> GetByEmail(string email)
        {
            try
            {
                var transacao = await _dbContext.Transacoes.FirstOrDefaultAsync(x => x.EmailCliente == email);
                return transacao;
            }
            catch
            {
                return null;
            }
        }

        public async Task<Transacao?> GetById(int id)
        {
            try
            {
                var transacao = await _dbContext.Transacoes.FirstOrDefaultAsync(x => x.Id == id);
                return transacao;
            }
            catch
            {
                return null;
            }
        }
    }
}
