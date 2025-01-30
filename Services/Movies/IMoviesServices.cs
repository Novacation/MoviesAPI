using MoviesApi.InputModels.Movies;
using MoviesApi.ViewModels.Movies;

namespace MoviesApi.Services.Movies;

public interface IMoviesServices
{
    Task CreateMovie(CreateMovieInputModel input);
    Task<GetMovieByIdViewModel?> GetMovieById(int id);
    Task UpdateMovie(UpdateMovieInputModel input);
}
