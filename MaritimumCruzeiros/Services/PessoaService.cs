using MaritimumCruzeiros.Data;
using MaritimumCruzeiros.Models;
using MaritimumCruzeiros.Models.DTOs;
using MaritimumCruzeiros.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MaritimumCruzeiros.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly DBContext _context;

        public PessoaService(DBContext context)
        {
            _context = context;
        }

        public Pessoa ConvertDTO(PessoaDTO pessoaDTO)
        {
            var pessoaId = pessoaDTO.Id == 0 ? null : pessoaDTO.Id;

            var pessoa = new Pessoa()
            {
                Id = pessoaId,
                Nome = pessoaDTO.Nome,
                Idade = pessoaDTO.Idade,
                SexoPessoaId = pessoaDTO.SexoPessoaId,
                Documento = pessoaDTO.Documento
            };

            return pessoa;
        }

        public async Task<bool> CreateOrUpdate(Pessoa pessoa)
        {
            try
            {
                if (pessoa.Id != null)
                {
                    _context.Pessoas.Update(pessoa);
                }
                else
                {
                    await _context.Pessoas.AddAsync(pessoa);
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
                var pessoa = await GetById(id);

                if(pessoa != null)
                {
                    _context.Pessoas.Remove(pessoa);
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

        public async Task<ICollection<Pessoa>?> GetAll()
        {
            try
            {
                var pessoas = await _context.Pessoas.ToListAsync();

                if(pessoas != null)
                {
                    return pessoas;
                }

                return null;
            }
            catch
            {
                return null;
            }
        }

        public async Task<Pessoa?> GetById(int id)
        {
            try
            {
                return await _context.Pessoas.FirstOrDefaultAsync(p => p.Id == id);
            }
            catch
            {
                return null;
            }
        }
    }
}
