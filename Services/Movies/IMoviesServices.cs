using MoviesApi.Dtos.Movies;
using MoviesApi.Entities;

namespace MoviesApi.Services.Movies;

public interface IMoviesServices
{
    Task CreateMovie(CreateMovieDto movie);
    Task<Filme?> GetMovieById(int id);
}