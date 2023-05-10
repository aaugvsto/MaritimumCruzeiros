using MaritimumCruzeiros.Data;
using MaritimumCruzeiros.Models;
using MaritimumCruzeiros.Models.DTOs;
using MaritimumCruzeiros.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MaritimumCruzeiros.Services
{
    public class PassagemService : IPassagemService
    {
        private readonly DBContext _dbContext;
        public PassagemService(DBContext dbContext) 
        {
            _dbContext = dbContext;
        }
        public Passagem ConvertDTO(PassagemDTO passagemDTO)
        {
            return new Passagem() 
            {
                Id = passagemDTO.Id,
                CruzeiroId = passagemDTO.CruzeiroId,
                NomeTitularDaPassagem = passagemDTO.NomeTitularDaPassagem,
                NumeroPassaporte = passagemDTO.NumeroPassaporte,
                PessoaCompradoraEmail = passagemDTO.PessoaCompradoraEmail,
                PessoaTitularEmail = passagemDTO.PessoaTitularEmail,
                TitularCPF = passagemDTO.TitularCPF,
            };
        }

        public async Task<bool> CreateOrUpdate(Passagem entity)
        {
            try
            {
                await _dbContext.Passagens.AddAsync(entity);
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
                var passagem = await GetById(id);
                if(passagem != null)
                {
                    _dbContext.Passagens.Remove(passagem);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public async Task<ICollection<Passagem>?> GetAll()
        {
            try
            {
                return await _dbContext.Passagens.ToListAsync();
            }
            catch 
            {
                return null;
            }
        }

        public async Task<Passagem?> GetById(int id)
        {
            try
            {
                return await _dbContext.Passagens.FirstOrDefaultAsync(x => x.Id == id);
            }
            catch
            {
                return null;
            }
        }
    }
}
