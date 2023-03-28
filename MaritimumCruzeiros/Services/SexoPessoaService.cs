using MaritimumCruzeiros.Data;
using MaritimumCruzeiros.Models;
using MaritimumCruzeiros.Models.DTOs;
using MaritimumCruzeiros.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MaritimumCruzeiros.Services
{
    public class SexoPessoaService : ISexoPessoaService
    {
        private readonly DBContext _dbContext;
        public SexoPessoaService(DBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public SexoPessoa ConvertDTO(SexoPessoaDTO sexoPessoaDto)
        {
            var sexo = new SexoPessoa()
            {
                Id = sexoPessoaDto.Id == 0 ? null : sexoPessoaDto.Id,
                Sexo = sexoPessoaDto.Sexo,
            };

            return sexo;
        }

        public async Task<bool> CreateOrUpdate(SexoPessoa sexoPessoa)
        {
            try
            {
                if(sexoPessoa.Id != null)
                {
                    _dbContext.SexoPessoa.Update(sexoPessoa);
                    await _dbContext.SaveChangesAsync();
                    return true;
                }

                await _dbContext.SexoPessoa.AddAsync(sexoPessoa);
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
                var sexo = await GetById(id);
                if(sexo != null)
                {
                    _dbContext.SexoPessoa.Remove(sexo);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public async Task<ICollection<SexoPessoa>?> GetAll()
        {
            try
            {
                return await _dbContext.SexoPessoa.ToListAsync();
            }
            catch
            {
                return null;
            }
        }

        public async Task<SexoPessoa?> GetById(int id)
        {
            try
            {
                return await _dbContext.SexoPessoa.FirstOrDefaultAsync(x => x.Id == id);
            }
            catch
            {
                return null;
            }
        }
    }
}
