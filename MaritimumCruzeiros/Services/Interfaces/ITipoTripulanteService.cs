using MaritimumCruzeiros.Models;
using MaritimumCruzeiros.Models.DTOs;

namespace MaritimumCruzeiros.Services.Interfaces
{
    public interface ITipoTripulanteService : IBaseService<TipoTripulante>
    {
        TipoTripulante ConvertDTO(TipoTripulanteDTO tipoTripulanteDTO);
    }
}
