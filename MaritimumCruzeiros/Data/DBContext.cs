using CruzeirosEmporio.Data.Map;
using MaritimumCruzeiros.Models;
using MaritimumCruzeiros.Data.Map;
using Microsoft.EntityFrameworkCore;

namespace MaritimumCruzeiros.Data
{
    public class DBContext : DbContext
    {
        public DbSet<Cruzeiro> Cruzeiros => Set<Cruzeiro>();
        public DbSet<Navio> Navios => Set<Navio>();
        public DbSet<Cabine> Cabines => Set<Cabine>();
        public DbSet<CabineTripulante> CabineTripulantes => Set<CabineTripulante>();
        public DbSet<Tripulante> Tripulantes => Set<Tripulante>();
        public DbSet<SexoPessoa> SexoPessoa => Set<SexoPessoa>();
        public DbSet<TipoTripulante> TipoTripulante => Set<TipoTripulante>();
        public DbSet<Pessoa> Pessoas => Set<Pessoa>();
        public DbSet<TipoCabine> TiposCabine => Set<TipoCabine>();
        public DbSet<Cupom> Cupons => Set<Cupom>();
        public DbSet<Transacao> Transacoes => Set<Transacao>();
        public DbSet<Passagem> Passagens => Set<Passagem>();

        public DBContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CabineMap());
            modelBuilder.ApplyConfiguration(new CruzeiroMap());
            modelBuilder.ApplyConfiguration(new NavioMap());
            modelBuilder.ApplyConfiguration(new PessoaMap());
            modelBuilder.ApplyConfiguration(new SexoPessoaMap());
            modelBuilder.ApplyConfiguration(new TipoCabineMap());
            modelBuilder.ApplyConfiguration(new TipoTripulanteMap());
            modelBuilder.ApplyConfiguration(new TripulanteMap());
            modelBuilder.ApplyConfiguration(new CabineTripulanteMap());
            modelBuilder.ApplyConfiguration(new CupomMap());
            modelBuilder.ApplyConfiguration(new TransacaoMap());
            modelBuilder.ApplyConfiguration(new PassagensMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
