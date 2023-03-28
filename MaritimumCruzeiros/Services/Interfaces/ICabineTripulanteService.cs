using MaritimumCruzeiros.Models;
using MaritimumCruzeiros.Models.DTOs;

namespace MaritimumCruzeiros.Services.Interfaces
{
    public interface ICabineTripulanteService : IBaseService<CabineTripulante>
    {
        CabineTripulante ConvertDTO(CabineTripulanteDTO cabineTripulanteDTO);
        Task<ICollection<CabineTripulante>?> GetByCabineId(int cabineId);
        Task<CabineTripulante?> GetByTripulanteId(int tripulanteId);
    }
}
