using MaritimumCruzeiros.Models;
using MaritimumCruzeiros.Models.DTOs;

namespace MaritimumCruzeiros.Services.Interfaces
{
    public interface IQuartoService : IBaseService<Cabine>
    {
        Task<IEnumerable<Cabine>> GetCabinesByNavio(int idNavio);
        Cabine ConvertDTO(CabineDTO cruzeiro);
    }
}
