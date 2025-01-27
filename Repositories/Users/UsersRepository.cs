using Microsoft.EntityFrameworkCore;
using MoviesApi.Entities;

namespace MoviesApi.Repositories.Users;

public class UsersRepository(AppDbContext dbContext) : IUsersRepository
{
    public async Task<List<Usuario>> GetAllUsers()
    {
        return await dbContext.UsuariosEntities.ToListAsync();
    }

    public async Task<Usuario?> GetUserByEmail(string email)
    {
        return await dbContext.UsuariosEntities.FirstOrDefaultAsync(u => u.Email == email);
    }

    public async Task<Usuario?> GetUserByCredentials(string email, string password)
    {
        return await dbContext.UsuariosEntities.FirstOrDefaultAsync(u => u.Email == email && u.Senha == password);
    }

    public async Task CreateUser(Usuario user)
    {
        await dbContext.UsuariosEntities.AddAsync(user);
        await dbContext.SaveChangesAsync();
    }

    public async Task UpdateUserJwt(Usuario user, string jwt)
    {
        user.UpdateJwt(jwt);

        await dbContext.SaveChangesAsync();
    }

    public async Task LogoffUser(Usuario user)
    {
        user.UpdateJwt(null);
        await dbContext.SaveChangesAsync();
    }
}
