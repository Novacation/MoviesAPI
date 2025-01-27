using MoviesApi.Entities;

namespace MoviesApi.Services.Users;

public interface IUsersServices
{
    Task<List<Usuario>> GetAllUsers();

    Task<Usuario?> GetUserByEmail(string email);

    Task<Usuario?> GetUserByCredentials(string email, string password);

    Task CreateUser(Usuario user);

    Task UpdateUserJwt(Usuario user);

    Task LogoffUser(Usuario user);
}
