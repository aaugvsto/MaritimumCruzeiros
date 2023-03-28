using System.ComponentModel;

namespace MaritimumCruzeiros.Models.Enums
{
    public class SexoTripulanteEnum
    {
        public enum SexoTripulante
        {
            [Description("Masculino")]
            M = 1,
            [Description("Feminino")]
            F = 2,
            [Description("Outro")]
            O = 3
        }
    }
}
