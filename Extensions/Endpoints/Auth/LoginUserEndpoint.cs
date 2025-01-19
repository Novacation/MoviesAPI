using MoviesApi.Dtos.Auth;
using MoviesApi.Services.Users;

namespace MoviesApi.Extensions.Endpoints.Auth;

public static class LoginUserEndpoint
{
    public static void MapEndpoint(RouteGroupBuilder app)
    {
        app.MapPost("/login-user", async (LoginUserDto loginUserDto, IUsersServices usersServices) =>
        {
            var user = await usersServices.GetUserByCredentials(loginUserDto.Email, loginUserDto.Password);

            if (user is null) return Results.Unauthorized();

            await usersServices.UpdateUserJwt(user);

            return Results.Ok();
        });
    }
}
