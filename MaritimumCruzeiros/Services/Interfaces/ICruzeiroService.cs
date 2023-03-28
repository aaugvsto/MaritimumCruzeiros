using MaritimumCruzeiros.Models;
using MaritimumCruzeiros.Models.DTOs;

namespace MaritimumCruzeiros.Services.Interfaces
{
    public interface ICruzeiroService : IBaseService<Cruzeiro>
    { 
        Cruzeiro ConvertDTO(CruzeiroDTO cruzeiro);
    }
}
