using MoviesApi.Entities;
using MoviesApi.InputModels.Movies;
using MoviesApi.Repositories.Movies;
using MoviesApi.ViewModels.Movies;

namespace MoviesApi.Services.Movies;

public class MoviesServices(IMoviesRepository moviesRepository) : IMoviesServices
{
    public async Task CreateMovie(CreateMovieInputModel input)
    {
        var movie = new Filme(nome: input.Nome, anoLancamento: input.Ano_Lancamento,
            diretor: input.Diretor, status: "Ativo", likes: input.Likes, dislikes: input.Dislikes);

        await moviesRepository.CreateMovie(movie);
    }

    public async Task<GetMovieByIdViewModel?> GetMovieById(int id)
    {
        var movie = await moviesRepository.GetMovieById(id);

        if (movie is not null)
        {
            return new GetMovieByIdViewModel(movie.Nome, movie.AnoLancamento, movie.Diretor, movie.Likes,
                movie.Dislikes);
        }

        return null;
    }

    public async Task UpdateMovie(UpdateMovieInputModel input)
    {
        var movie = await moviesRepository.GetMovieById(input.Id); //AsNoTracking() -> Não vai rastrear mudanças

        if (movie is not null)
        {
            movie.Update(input.Nome, input.AnoLancamento, input.Diretor, input.Status, input.Likes, input.Dislikes);
            await moviesRepository.UpdateMovie(movie);
        }
    }
}
