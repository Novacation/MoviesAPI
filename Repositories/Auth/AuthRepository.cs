
using Microsoft.EntityFrameworkCore;
using MoviesApi.Entities;

namespace MoviesApi.Repositories.Auth
{
    public class AuthRepository(AppDbContext dbContext) : IAuthRepository
    {
        
    }
}