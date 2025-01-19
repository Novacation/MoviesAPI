using Microsoft.EntityFrameworkCore;
using MoviesApi.Entities;

namespace MoviesApi;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public required DbSet<Usuario> UsuariosEntities { get; set; }

    public required DbSet<Filme> FilmesEntities { get; set; }

    public required DbSet<UsuarioFilme> UsuarioFilmeEntities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}
