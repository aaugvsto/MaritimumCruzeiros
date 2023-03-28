namespace MaritimumCruzeiros.Models.DTOs
{
    public class CabineDTO
    {
        public int Id { get; set; }
        public int NavioId { get; set; }
        public string? Numero { get; set; }
        public string? Piso { get; set; }
        public int CapacidadeMaxima { get; set; }
        public int TipoCabineId { get; set; }
    }
}
