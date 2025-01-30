using Microsoft.AspNetCore.Authorization;
using MoviesApi.InputModels.Movies;
using MoviesApi.Services.Movies;

namespace MoviesApi.Extensions.Endpoints.Movies;

public static class CreateMovieEndpoint
{
    public static void MapEndpoint(RouteGroupBuilder app)
    {
        app.MapPost("/create", [Authorize] async (CreateMovieInputModel input, IMoviesServices moviesServices) =>
        {
            await moviesServices.CreateMovie(input);

            return Results.Created($"/name/{input.Nome}", input);
        });
    }
}
