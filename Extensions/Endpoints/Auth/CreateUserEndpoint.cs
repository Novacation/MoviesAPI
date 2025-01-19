using MoviesApi.Dtos.Auth;
using MoviesApi.Entities;
using MoviesApi.Services.Auth;
using MoviesApi.Services.Users;

namespace MoviesApi.Extensions.Endpoints.Auth;

public static class CreateUserEndpoint
{
    public static void MapEndpoint(RouteGroupBuilder app)
    {
        app.MapPost("/create-user", async (CreateUserDto createUserDto, IUsersServices usersServices, IAuthServices
            authServices) =>
        {
            var possibleUser = await usersServices.GetUserByEmail(createUserDto.Email);

            if (possibleUser is not null) return Results.Conflict("E-mail já cadastrado");

            var jwt = authServices.GenerateJwt(createUserDto.Email);

            await usersServices.CreateUser(new Usuario(createUserDto.Nome, createUserDto.Email, createUserDto
                .Password, "Ativo", jwt));

            return Results.Created("Create User",
                new
                {
                    Token = jwt
                });
        });
    }
}
