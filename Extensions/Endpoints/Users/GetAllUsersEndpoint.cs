using Microsoft.AspNetCore.Authorization;
using MoviesApi.Services.Users;

namespace MoviesApi.Extensions.Endpoints.Users;

public static class GetAllUsersEndpoint
{
    public static void MapEndpoint(RouteGroupBuilder app)
    {
        app.MapGet("/", [Authorize] async (IUsersServices usersServices) =>
        {
            var users = await usersServices.GetAllUsers();

            return Results.Ok(users);
        });
    }
}
