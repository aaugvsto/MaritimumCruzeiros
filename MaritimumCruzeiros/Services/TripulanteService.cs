using MaritimumCruzeiros.Data;
using MaritimumCruzeiros.Models;
using MaritimumCruzeiros.Models.DTOs;
using MaritimumCruzeiros.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CruzeirosEmporio.Services
{
    public class TripulanteService : ITripulanteService
    {
        private readonly DBContext _context;
        public TripulanteService(DBContext cruzeiroContext) 
        {
            _context = cruzeiroContext;
        }
        public async Task<bool> CreateOrUpdate(Tripulante tripulante)
        {
            try
            {                
                if (tripulante.Id != null)
                {
                    _context.Tripulantes.Update(tripulante);
                }
                else
                {
                    await _context.Tripulantes.AddAsync(tripulante);
                }            

                await _context.SaveChangesAsync();
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
                var tripulante = await GetById(id);
                if (tripulante != null)
                {
                    _context.Tripulantes.Remove(tripulante);
                    await _context.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public async Task<ICollection<Tripulante>?> GetAll()
        {
            try
            {
                var tripulante = await _context.Tripulantes.ToListAsync();
                return tripulante;
            }
            catch
            {
                return null;
            }
        }

        public async Task<Tripulante?> GetById(int id)
        {
            try
            {
                var tripulante = await _context.Tripulantes.FirstOrDefaultAsync(x => x.Id == id);
                return tripulante;
            }
            catch
            {
                return null;
            }
        }

        public Tripulante ConvertDTO(TripulanteDTO tripulante)
        {
            var tripulanteId = tripulante.Id == 0 ? null : tripulante.Id;

            var converted = new Tripulante()
            {
                Id = tripulanteId,
                PessoaId = tripulante.PessoaId,
                TipoTripulanteId = tripulante.TipoTripulanteId,
                CruzeiroId = tripulante.CruzeiroId,
                CabineTripulanteId = tripulante.CabineTripulanteId
            };
            return converted;
        }
    }
}
