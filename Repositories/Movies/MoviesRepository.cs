using Microsoft.EntityFrameworkCore;
using MoviesApi.Entities;

namespace MoviesApi.Repositories.Movies;

public class MoviesRepository(AppDbContext dbContext) : IMoviesRepository
{
    public async Task CreateMovie(Filme movie)
    {
        await dbContext.FilmesEntities.AddAsync(movie);

        await dbContext.SaveChangesAsync();
    }

    public async Task<Filme?> GetMovieById(int id)
    {
        return
            await dbContext.FilmesEntities.AsNoTracking()
                .SingleOrDefaultAsync(m =>
                    m.Id == id); //Retorna a instância que contém esse "Id", sem ficar rastreando por mudanças no decorrer do fluxo do código.
    }

    public async Task UpdateMovie(Filme movie)
    {
        dbContext.FilmesEntities.Update(movie); //Começa a trackear novamente por mudanças sofridas
        await dbContext.SaveChangesAsync(); //Envia as mudanças pro banco
    }
}
