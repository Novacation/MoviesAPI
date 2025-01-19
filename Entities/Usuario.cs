namespace MoviesApi.Entities;

public class Usuario(string nome, string email, string senha, string status, string? jwt)
{
    public int Id { get; private set; }

    public string Nome { get; private set; } = nome;

    public string Email { get; private set; } = email;

    public string Senha { get; private set; } = senha;

    public string Status { get; private set; } = status;

    public string? Jwt { get; private set; } = jwt;

    public void UpdateJwt(string? token)
    {
        Jwt = token;
    }
}
