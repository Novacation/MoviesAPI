using MoviesApi.Entities;

namespace MoviesApi.Repositories.Users;

public interface IUsersRepository
{
    Task<Usuario?> GetUserByEmail(string email);

    Task<Usuario?> GetUserByCredentials(string email, string password);

    Task CreateUser(Usuario user);

    Task UpdateUserJwt(Usuario user, string jwt);

    Task LogoffUser(Usuario user);
}