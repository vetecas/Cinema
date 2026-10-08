using CinemaDomain;
using CinemaRepositorio.Mapping;
using Microsoft.EntityFrameworkCore;

namespace CinemaRepositorio.Context
{
    public class MyDBContext : DbContext
    {
        public DbSet<Genero> Genero { get; set; }
        public DbSet<Filme> Filme { get; set; }
        public DbSet<Sala> Sala { get; set; }
        public DbSet<Sessao> Sessao { get; set; }
        public DbSet<Ingresso> Ingresso { get; set; }
        public DbSet<IngressoItem> IngressoItem { get; set; }

        public MyDBContext()
        {
            Database.EnsureCreated(); // Verifica se o banco existe, se não tiver ele cria
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new GeneroMap());
            modelBuilder.ApplyConfiguration(new FilmeMap());
            modelBuilder.ApplyConfiguration(new SalaMap());
            modelBuilder.ApplyConfiguration(new SessaoMap());
            modelBuilder.ApplyConfiguration(new IngressoMap());
            modelBuilder.ApplyConfiguration(new IngressoItemMap());
        }
    }
}
