namespace MoviesApi.Extensions.Endpoints.Auth;

public static class MapAuthEndpoints
{
    public static void Execute(RouteGroupBuilder routeGroupBuilder)
    {
        CreateUserEndpoint.MapEndpoint(routeGroupBuilder);
        LoginUserEndpoint.MapEndpoint(routeGroupBuilder);
        LogoffUserEndpoint.MapEndpoint(routeGroupBuilder);
    }
}
