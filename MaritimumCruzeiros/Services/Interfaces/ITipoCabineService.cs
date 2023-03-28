using MaritimumCruzeiros.Models;
using MaritimumCruzeiros.Models.DTOs;

namespace MaritimumCruzeiros.Services.Interfaces
{
    public interface ITipoCabineService : IBaseService<TipoCabine>
    {
        TipoCabine ConvertDTO(TipoCabineDTO tipoCabineDTO);
    }
}
