using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MoviesApi.Dtos.Users;
using MoviesApi.Services.Users;

namespace MoviesApi.Extensions.Endpoints.Users;

public static class GetUserByEmailEndpoint
{
    public static void MapEndpoint(RouteGroupBuilder app)
    {
        app.MapGet("/byemail/{email}", async ([FromRoute] string email, IUsersServices
            usersServices) =>
        {
            var user = await usersServices.GetUserByEmail(email);

            if (user is null)
            {
                return Results.NotFound();
            }

            return Results.Ok(user);
        });
    }
}
