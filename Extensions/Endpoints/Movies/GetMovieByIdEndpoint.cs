using Microsoft.AspNetCore.Authorization;
using MoviesApi.Services.Movies;

namespace MoviesApi.Extensions.Endpoints.Movies;

public static class GetMovieByIdEndpoint
{
    public static void MapEndpoint(RouteGroupBuilder app)
    {
        app.MapGet("/{id:int}", [Authorize] async (int id, IMoviesServices moviesServices) =>
        {
            var movie = await moviesServices.GetMovieById(id);

            if (movie is null) return Results.NotFound();

            return Results.Ok(movie);
        });
    }
}
