using MaritimumCruzeiros.Models;
using MaritimumCruzeiros.Models.DTOs;

namespace MaritimumCruzeiros.Services.Interfaces
{
    public interface ICupomService : IBaseService<Cupom>
    {
        Cupom ConvertDTO(CupomDTO cupom);
        Task<Cupom?> GetByCodigo(string codigo);
    }
}
