namespace MaritimumCruzeiros.Models.DTOs
{
    public class TripulanteDTO
    {
        public int? Id { get; set; }
        public int PessoaId { get; set; }
        public int TipoTripulanteId { get; set; }
        public int CruzeiroId { get; set; }
        public int? CabineTripulanteId { get; set; }
    }
}
