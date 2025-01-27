namespace MoviesApi.Dtos.Users;

public class GetUserByEmailDto(string email)
{
    public string Email { get; private set; } = email;
}
