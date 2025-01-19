namespace MoviesApi.Extensions.Endpoints.Movies;

public static class MapMoviesEndpoints
{
    public static void Execute(RouteGroupBuilder app)
    {
        CreateMovieEndpoint.MapEndpoint(app);
        GetMovieByIdEndpoint.MapEndpoint(app);
    }
}
