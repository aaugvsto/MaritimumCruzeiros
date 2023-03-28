using MaritimumCruzeiros.Data;
using MaritimumCruzeiros.Models;
using MaritimumCruzeiros.Models.DTOs;
using MaritimumCruzeiros.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CruzeirosEmporio.Services
{
    public class CruzeiroService : ICruzeiroService
    {
        private readonly DBContext _context;
        public CruzeiroService(DBContext context)
        {
            _context = context;
        }

        public Cruzeiro ConvertDTO(CruzeiroDTO cruzeiroDTO)
        {
            var cruzeiro = new Cruzeiro()
            {
                Id = cruzeiroDTO.Id == 0 ? null : cruzeiroDTO.Id,
                NomeExpedicao = cruzeiroDTO.NomeExpedicao,
                DataPartida = cruzeiroDTO.DataPartida,
                DataChegada = cruzeiroDTO.DataChegada,
                Descricao = cruzeiroDTO.Descricao,
                NavioId = cruzeiroDTO.NavioId,
            };

            return cruzeiro;
        }

        public async Task<bool> CreateOrUpdate(Cruzeiro cruzeiro)
        {
            try
            {
                if (cruzeiro.Id != null)
                {
                    _context.Cruzeiros.Update(cruzeiro);
                    await _context.SaveChangesAsync();
                    return true;
                }
                else
                {
                    await _context.Cruzeiros.AddAsync(cruzeiro);
                    await _context.SaveChangesAsync();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> Delete(int cruzeiroId)
        {
            try
            {
                var cruzeiro = await GetById(cruzeiroId);

                if (cruzeiro != null)
                {
                    _context.Cruzeiros.Remove(cruzeiro);
                    _context.SaveChanges();
                    return true;
                }

                return false;
            }
            catch 
            { 
                return false; 
            }
        }

        public async Task<ICollection<Cruzeiro>?> GetAll()
        {
            try
            {
                return await _context.Cruzeiros.ToListAsync();
            }
            catch
            {
                return null;
            }
        }

        public async Task<Cruzeiro?> GetById(int id)
        {
            try
            {
                return await _context.Cruzeiros.FirstOrDefaultAsync(x => x.Id == id);
            }
            catch
            {
                return null;
            }
        }
    }
}
