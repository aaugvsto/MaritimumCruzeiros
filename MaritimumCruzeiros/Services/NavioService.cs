using MaritimumCruzeiros.Data;
using MaritimumCruzeiros.Models;
using MaritimumCruzeiros.Models.DTOs;
using MaritimumCruzeiros.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CruzeirosEmporio.Services
{
    public class NavioService : INavioService
    {
        private readonly DBContext _context;
        public NavioService(DBContext cruzeiroContext) 
        {
            _context = cruzeiroContext;
        }

        public Navio ConvertDTO(NavioDTO navioDTO)
        {
            var navio = new Navio()
            {
                Id = navioDTO.Id == 0 ? null : navioDTO.Id,
                Nome = navioDTO.Nome,
                CapacidadePessoas = navioDTO.CapacidadePessoas
            };

            return navio;
        }

        public async Task<bool> CreateOrUpdate(Navio navio)
        {
            try
            {
                if(navio.Id != null)
                {
                    _context.Navios.Update(navio);
                    await _context.SaveChangesAsync();
                    return true;
                }
                else
                {
                    await _context.Navios.AddAsync(navio);
                    await _context.SaveChangesAsync();
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
                var navio = await GetById(id);
                if (navio != null)
                {
                    _context.Navios.Remove(navio);
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

        public async Task<ICollection<Navio>?> GetAll()
        {
            try
            {
                return await _context.Navios.ToListAsync();
            }
            catch
            {
                return null;
            }
        }

        public async Task<Navio?> GetById(int id)
        {
            try
            {
                return await _context.Navios.FirstOrDefaultAsync(x => x.Id == id);
            }
            catch
            {
                return null;
            }
        }
    }
}
