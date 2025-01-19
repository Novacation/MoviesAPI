using MoviesApi.Dtos.Movies;
using MoviesApi.Entities;
using MoviesApi.Repositories.Movies;

namespace MoviesApi.Services.Movies;

public class MoviesServices(IMoviesRepository moviesRepository) : IMoviesServices
{
    public async Task CreateMovie(CreateMovieDto movie) => await moviesRepository.CreateMovie(movie);

    public async Task<Filme?> GetMovieById(int id) => await moviesRepository.GetMovieById(id);
}