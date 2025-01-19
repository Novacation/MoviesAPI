using Microsoft.AspNetCore.Authorization;
using MoviesApi.Dtos.Movies;
using MoviesApi.Services.Movies;

namespace MoviesApi.Extensions.Endpoints.Movies;

public static class CreateMovieEndpoint
{
    public static void MapEndpoint(RouteGroupBuilder app)
    {
        app.MapPost("/create", async (CreateMovieDto movieDto, IMoviesServices moviesServices) =>
        {
            await moviesServices.CreateMovie(movieDto);

            return Results.Created($"/name/{movieDto.Nome}", movieDto);
        });
    }
}
