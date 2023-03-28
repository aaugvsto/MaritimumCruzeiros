using MaritimumCruzeiros.Data;
using MaritimumCruzeiros.Models;
using MaritimumCruzeiros.Models.DTOs;
using MaritimumCruzeiros.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MaritimumCruzeiros.Services
{
    public class TipoCabineService : ITipoCabineService
    {
        private readonly DBContext _dbContext;
        public TipoCabineService(DBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public TipoCabine ConvertDTO(TipoCabineDTO tipoCabineDTO)
        {
            var tipoCabine = new TipoCabine()
            {
                Id = tipoCabineDTO.Id == 0 ? null : tipoCabineDTO.Id,
                Tipo = tipoCabineDTO.Tipo,
                Descricao = tipoCabineDTO.Descricao
            };

            return tipoCabine;
        }

        public async Task<bool> CreateOrUpdate(TipoCabine tipoCabine)
        {
            try
            {
                if (tipoCabine.Id != null)
                {
                    _dbContext.TiposCabine.Update(tipoCabine);
                    await _dbContext.SaveChangesAsync();
                    return true;
                }

                await _dbContext.TiposCabine.AddAsync(tipoCabine);
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
                var tipoCabine = await GetById(id);
                if(tipoCabine != null)
                {
                    _dbContext.TiposCabine.Remove(tipoCabine);
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

        public async Task<ICollection<TipoCabine>?> GetAll()
        {
            try
            {
                return await _dbContext.TiposCabine.ToListAsync();
            }
            catch
            {
                return null;
            }
        }

        public async Task<TipoCabine?> GetById(int id)
        {
            try
            {
                return await _dbContext.TiposCabine.FirstOrDefaultAsync(x => x.Id == id);
            }
            catch
            {
                return null;
            }
        }
    }
}
