namespace MaritimumCruzeiros.Models.DTOs
{
    public class CruzeiroDTO
    {
        public int Id { get; set; }
        public string? NomeExpedicao { get; set; }
        public DateTime DataPartida { get; set; }
        public DateTime DataChegada { get; set; }
        public string? Descricao { get; set; }
        public int? NavioId { get; set; }
    }
}
