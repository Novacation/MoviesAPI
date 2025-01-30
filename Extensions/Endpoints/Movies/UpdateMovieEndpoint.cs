using Microsoft.AspNetCore.Authorization;
using MoviesApi.InputModels.Movies;

namespace MoviesApi.Extensions.Endpoints.Movies;

public static class UpdateMovieEndpoint
{
    public static void MapEndpoint(RouteGroupBuilder app)
    {
        app.MapPut("/", [Authorize] async (UpdateMovieInputModel input) => { });
    }
}
