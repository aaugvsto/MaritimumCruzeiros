namespace MaritimumCruzeiros.Models.DTOs
{
    public class CabineTripulanteDTO
    {
        public int? CabineTripulanteId { get; set; }
        public int CabineId { get; set; }
        public int TripulanteId { get; set; }
        public int CruzeiroId { get; set; }
    }
}
