using MaritimumCruzeiros.Models;
using MaritimumCruzeiros.Models.DTOs;

namespace MaritimumCruzeiros.Services.Interfaces
{
    public interface IPessoaService : IBaseService<Pessoa>
    {
        Pessoa ConvertDTO(PessoaDTO pessoaDTO);
        Task<Pessoa?> GetByEmail(string email);
        Task<Pessoa?> Login(string email, string password);
    }
}
