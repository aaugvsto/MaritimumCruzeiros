using MaritimumCruzeiros.Models;
using MaritimumCruzeiros.Models.DTOs;

namespace MaritimumCruzeiros.Services.Interfaces
{
    public interface ITripulanteService : IBaseService<Tripulante>
    {
        Tripulante ConvertDTO(TripulanteDTO tripulanteDTO);
    }
}
