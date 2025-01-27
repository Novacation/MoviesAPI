using MoviesApi.Entities;
using MoviesApi.Repositories.Users;
using MoviesApi.Services.Auth;

namespace MoviesApi.Services.Users;

public class UsersServices(IUsersRepository usersRepository, IAuthServices authServices) : IUsersServices
{
    public async Task<List<Usuario>> GetAllUsers()
    {
        return await usersRepository.GetAllUsers();
    }

    public async Task<Usuario?> GetUserByEmail(string email)
    {
        return await usersRepository.GetUserByEmail(email);
    }

    public async Task<Usuario?> GetUserByCredentials(string email, string password)
    {
        return await usersRepository.GetUserByCredentials(email, password);
    }

    public async Task CreateUser(Usuario user)
    {
        await usersRepository.CreateUser(user);
    }

    public async Task UpdateUserJwt(Usuario user)
    {
        var jwt = authServices.GenerateJwt(user.Email);

        await usersRepository.UpdateUserJwt(user, jwt);
    }

    public async Task LogoffUser(Usuario user)
    {
        await usersRepository.LogoffUser(user);
    }
}
