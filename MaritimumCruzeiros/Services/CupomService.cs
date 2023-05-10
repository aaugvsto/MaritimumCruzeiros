using MaritimumCruzeiros.Data;
using MaritimumCruzeiros.Data.Map;
using MaritimumCruzeiros.Models;
using MaritimumCruzeiros.Models.DTOs;
using MaritimumCruzeiros.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MaritimumCruzeiros.Services
{
    public class CupomService : ICupomService
    {

        private readonly DBContext _dbContext;

        public CupomService(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Cupom ConvertDTO(CupomDTO cupom)
        {
            return new Cupom() {
                IdCupom = cupom.IdCupom ?? 0,
                Codigo = cupom.Codigo,
                PorcentagemDesconto = cupom.PorcentagemDesconto,
            };
        }

        public async Task<bool> CreateOrUpdate(Cupom cupom)
        {
            try
            {
                await _dbContext.Cupons.AddAsync(cupom);
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
                Cupom? toRemove = await GetById(id);
                if(toRemove != null)
                {
                    _dbContext.Cupons.Remove(toRemove);
                    await _dbContext.SaveChangesAsync();
                    return true;
                }                
                    
                return false;
            }
            catch 
            {
                return false;
            }
        }

        public async Task<ICollection<Cupom>?> GetAll()
        {
            try
            {
                return await _dbContext.Cupons.ToListAsync();
            }
            catch
            {
                return null;
            }
        }

        public async Task<Cupom?> GetById(int id)
        {
            try
            {
                var cupom = await _dbContext.Cupons.FirstOrDefaultAsync(x => x.IdCupom == id);
                return cupom;
            }
            catch
            {
                return null;
            }
        }

        public async Task<Cupom?> GetByCodigo(string codigo)
        {
            try
            {
                var cupom = await _dbContext.Cupons.FirstOrDefaultAsync(x => x.Codigo == codigo);
                return cupom;
            }
            catch
            {
                return null;
            }
        }
    }
}
