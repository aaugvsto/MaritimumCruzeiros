using MaritimumCruzeiros.Data;
using MaritimumCruzeiros.Models;
using MaritimumCruzeiros.Models.DTOs;
using MaritimumCruzeiros.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MaritimumCruzeiros.Services
{
    public class CabineTripulanteService : ICabineTripulanteService
    {
        public readonly DBContext _dbContext;

        public CabineTripulanteService(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public CabineTripulante ConvertDTO(CabineTripulanteDTO cabineTripulanteDTO)
        {
            var cabineTripulante = new CabineTripulante()
            {
                CabineTripulanteId = cabineTripulanteDTO.CabineTripulanteId == 0 ? null : cabineTripulanteDTO.CabineTripulanteId,
                CabineId = cabineTripulanteDTO.CabineId,
                TripulanteId = cabineTripulanteDTO.TripulanteId,
                CruzeiroId = cabineTripulanteDTO.CruzeiroId
            };

            return cabineTripulante;
        }

        public async Task<bool> CreateOrUpdate(CabineTripulante cabineTripulante)
        {
            try
            {
                if(cabineTripulante.CabineTripulanteId.HasValue)
                    _dbContext.CabineTripulantes.Update(cabineTripulante);

                if(!cabineTripulante.CabineTripulanteId.HasValue)
                    await _dbContext.CabineTripulantes.AddAsync(cabineTripulante);

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
                var cabineTripulante = await GetById(id);
                if(cabineTripulante != null)
                {
                    _dbContext.CabineTripulantes.Remove(cabineTripulante);
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

        public async Task<ICollection<CabineTripulante>?> GetAll()
        {
            try
            {
                var cabinesTripulantes = await _dbContext.CabineTripulantes.ToListAsync();
                return cabinesTripulantes;
            }
            catch
            {
                return null;
            }
        }

        public async Task<ICollection<CabineTripulante>?> GetByCabineId(int cabineId)
        {
            try
            {
                var cabineTripulante = await _dbContext.CabineTripulantes.Where(x => x.CabineId == cabineId).ToListAsync();
                return cabineTripulante;
            }
            catch
            {
                return null;
            }
        }

        public async Task<CabineTripulante?> GetById(int id)
        {
            try
            {
                var cabineTripulante = await _dbContext.CabineTripulantes.FirstOrDefaultAsync(x => x.CabineTripulanteId == id);
                return cabineTripulante;
            }
            catch
            {
                return null;
            }
        }

        public async Task<CabineTripulante?> GetByTripulanteId(int tripulanteId)
        {
            try
            {
                var cabineTripulante = await _dbContext.CabineTripulantes.FirstOrDefaultAsync(x => x.TripulanteId == tripulanteId);
                return cabineTripulante;
            }
            catch
            {
                return null;
            }
        }
    }
}
