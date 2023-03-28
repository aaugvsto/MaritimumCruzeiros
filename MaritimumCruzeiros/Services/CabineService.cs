using MaritimumCruzeiros.Data;
using MaritimumCruzeiros.Models;
using MaritimumCruzeiros.Models.DTOs;
using MaritimumCruzeiros.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MaritimumCruzeiros.Services
{
    public class CabineService : ICabineService
    {
        private readonly DBContext _dbContext;

        public CabineService(DBContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public Cabine ConvertDTO(CabineDTO cabineDTO)
        {
            var cabine = new Cabine()
            {
                Id = cabineDTO.Id == 0 ? null : cabineDTO.Id,
                NavioId = cabineDTO.NavioId,
                Numero = cabineDTO.Numero,
                Piso = cabineDTO.Piso,
                CapacidadeMaxima = cabineDTO.CapacidadeMaxima,
                TipoCabineId = cabineDTO.TipoCabineId
            };

            return cabine;
        }

        public async Task<bool> CreateOrUpdate(Cabine cabine)
        {
            try
            {
                if (cabine.Id.HasValue)
                    _dbContext.Cabines.Update(cabine);

                if (!cabine.Id.HasValue)
                    await _dbContext.Cabines.AddAsync(cabine);

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
                var cabine = await GetById(id);
                if(cabine != null)
                {
                    _dbContext.Cabines.Remove(cabine);
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

        public async Task<ICollection<Cabine>?> GetAll()
        {
            try
            {
                var cabines = await _dbContext.Cabines.ToListAsync();
                return cabines;
            }
            catch
            { 
                return null; 
            }
        }

        public async Task<Cabine?> GetById(int id)
        {
            try
            {
                var cabine = await _dbContext.Cabines.FirstOrDefaultAsync(x => x.Id == id);
                return cabine;
            }
            catch
            {
                return null;
            }
        }
    }
}
