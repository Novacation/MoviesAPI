namespace MoviesApi.Extensions.Endpoints.Users;

public static class MapUsersEndpoints
{
    public static void Execute(RouteGroupBuilder app)
    {
        GetAllUsersEndpoint.MapEndpoint(app);
        GetUserByEmailEndpoint.MapEndpoint(app);
    }
}
