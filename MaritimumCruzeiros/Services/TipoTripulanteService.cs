using MaritimumCruzeiros.Data;
using MaritimumCruzeiros.Models;
using MaritimumCruzeiros.Models.DTOs;
using MaritimumCruzeiros.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Eventing.Reader;

namespace MaritimumCruzeiros.Services
{
    public class TipoTripulanteService : ITipoTripulanteService
    {
        private readonly DBContext _dbContext;
        public TipoTripulanteService(DBContext dbContext) 
        {
            _dbContext = dbContext;
        }
        public TipoTripulante ConvertDTO(TipoTripulanteDTO tipoTripulanteDTO)
        {
            var tipoTripulante = new TipoTripulante()
            {
                Id = tipoTripulanteDTO.Id == 0 ? null : tipoTripulanteDTO.Id,
                Tipo = tipoTripulanteDTO.Tipo
            };

            return tipoTripulante;
        }

        public async Task<bool> CreateOrUpdate(TipoTripulante tipoTripulante)
        {
            try
            {
                if (tipoTripulante.Id.HasValue)
                {
                    _dbContext.TipoTripulante.Update(tipoTripulante);
                    await _dbContext.SaveChangesAsync();
                    return true;
                }
                else
                {
                    await _dbContext.TipoTripulante.AddAsync(tipoTripulante);
                    await _dbContext.SaveChangesAsync();
                    return true;
                }
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
                var tipoTripulante = await GetById(id);
                if(tipoTripulante != null)
                {
                    _dbContext.TipoTripulante.Remove(tipoTripulante);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public async Task<ICollection<TipoTripulante>?> GetAll()
        {
            try
            {
                return await _dbContext.TipoTripulante.ToListAsync();
            }
            catch
            {
                return null;
            }
        }

        public async Task<TipoTripulante?> GetById(int id)
        {
            try
            {
                return await _dbContext.TipoTripulante.FirstOrDefaultAsync(x => x.Id == id);
            }
            catch
            {
                return null;
            }
        }
    }
}
