namespace MoviesApi.Services.Auth;

public interface IAuthServices
{
    string GenerateJwt(string email);
}
