namespace MaritimumCruzeiros.Models
{
    public class CabineTripulante
    {
        public int? CabineTripulanteId { get; set; }
        public int CabineId { get; set; }
        public int TripulanteId { get; set; }
        public int CruzeiroId { get; set; }

        public virtual Cabine? Cabine { get; set; }
        public virtual Tripulante? Tripulante { get; set; }
        public virtual Cruzeiro? Cruzeiro { get; set; }
    }
}
