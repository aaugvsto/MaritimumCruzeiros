namespace MaritimumCruzeiros.Models
{
    public class Tripulante
    {
        public int? Id { get; set; }
        public int PessoaId { get; set; }
        public int TipoTripulanteId { get; set; }
        public int CruzeiroId { get; set; }
        public int? CabineTripulanteId { get; set; }

        public virtual Pessoa? Pessoa { get; set; }
        public virtual TipoTripulante? TipoTripulante { get; set; }
        public virtual Cruzeiro? Cruzeiro { get; set; }
        public virtual CabineTripulante? CabineTripulante { get; set; }
    }
}
