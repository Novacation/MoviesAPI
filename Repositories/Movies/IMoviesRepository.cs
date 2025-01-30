using MoviesApi.Entities;

namespace MoviesApi.Repositories.Movies;

public interface IMoviesRepository
{
    Task CreateMovie(Filme movie);
    Task<Filme?> GetMovieById(int id);
    Task UpdateMovie(Filme movie);
}
