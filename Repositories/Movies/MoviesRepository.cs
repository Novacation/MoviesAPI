using Microsoft.EntityFrameworkCore;
using MoviesApi.Dtos.Movies;
using MoviesApi.Entities;

namespace MoviesApi.Repositories.Movies;

public class MoviesRepository(AppDbContext dbContext) : IMoviesRepository
{
    public async Task CreateMovie(CreateMovieDto movie)
    {
        await dbContext.FilmesEntities.AddAsync(new Filme(nome: movie.Nome, anoLancamento: movie.Ano_Lancamento,
            diretor: movie.Diretor, status: "Ativo", likes: movie.Likes, dislikes: movie.Dislikes));

        await dbContext.SaveChangesAsync();
    }

    public async Task<Filme?> GetMovieById(int id)
    {
        return await dbContext.FilmesEntities.FirstOrDefaultAsync(m => m.Id == id);
    }
}
