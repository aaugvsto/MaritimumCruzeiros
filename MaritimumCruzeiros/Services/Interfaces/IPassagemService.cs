using MaritimumCruzeiros.Models;
using MaritimumCruzeiros.Models.DTOs;

namespace MaritimumCruzeiros.Services.Interfaces
{
    public interface IPassagemService : IBaseService<Passagem>
    {
        Passagem ConvertDTO(PassagemDTO passagemDTO);

        Task<List<Passagem>> FindByEmail(string email);
    }
}
