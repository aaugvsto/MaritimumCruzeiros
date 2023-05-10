using MaritimumCruzeiros.Models;
using MaritimumCruzeiros.Models.DTOs;

namespace MaritimumCruzeiros.Services.Interfaces
{
    public interface ITransacaoService : IBaseService<Transacao>
    {
        Transacao ConvertDTO(TransacaoDTO transacaoDTO);
        Task<Transacao?> GetByEmail(string email);
    }
}
