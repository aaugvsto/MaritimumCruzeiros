using MaritimumCruzeiros.Models;
using MaritimumCruzeiros.Models.DTOs;

namespace MaritimumCruzeiros.Services.Interfaces
{
    public interface ICabineService : IBaseService<Cabine>
    {
        Cabine ConvertDTO(CabineDTO cabineDTO);
    }
}
