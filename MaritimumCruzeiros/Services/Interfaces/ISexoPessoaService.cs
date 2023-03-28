using MaritimumCruzeiros.Models;
using MaritimumCruzeiros.Models.DTOs;

namespace MaritimumCruzeiros.Services.Interfaces
{
    public interface ISexoPessoaService : IBaseService<SexoPessoa>
    {
        SexoPessoa ConvertDTO(SexoPessoaDTO dto);
    }
}
