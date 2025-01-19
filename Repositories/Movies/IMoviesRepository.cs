using MoviesApi.Dtos.Movies;
using MoviesApi.Entities;

namespace MoviesApi.Repositories.Movies;

public interface IMoviesRepository
{
    Task CreateMovie(CreateMovieDto movie);
    Task<Filme?> GetMovieById(int id);
}