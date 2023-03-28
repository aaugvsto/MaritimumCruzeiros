using MaritimumCruzeiros.Models;
using MaritimumCruzeiros.Models.DTOs;

namespace MaritimumCruzeiros.Services.Interfaces
{
    public interface INavioService : IBaseService<Navio>
    {
        Navio ConvertDTO(NavioDTO navioDTO);
    }
}
