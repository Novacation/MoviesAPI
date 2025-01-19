using Microsoft.AspNetCore.Authorization;
using MoviesApi.Services.Users;

namespace MoviesApi.Extensions.Endpoints.Auth;

public static class LogoffUserEndpoint
{
    public static void MapEndpoint(RouteGroupBuilder app)
    {
        app.MapDelete("/logoff-user", [Authorize] async (IUsersServices usersServices, HttpContext context) =>
        {
            var email = context.User.Claims.ToList().FirstOrDefault(c =>
                c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress")?.Value;

            Console.WriteLine(email);

            if (email is null) return Results.Unauthorized();

            var user = await usersServices.GetUserByEmail(email);

            if (user is null) return Results.Unauthorized();

            await usersServices.LogoffUser(user);

            return Results.Ok();
        });
    }
}
