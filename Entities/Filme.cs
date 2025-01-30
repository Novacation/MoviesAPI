namespace MoviesApi.Entities;

public class Filme(string nome, int anoLancamento, string diretor, string status, int likes, int dislikes)
{
    public int Id { get; init; }

    public string Nome { get; private set; } = nome;

    public int AnoLancamento { get; private set; } = anoLancamento;

    public string Diretor { get; private set; } = diretor;

    public string Status { get; private set; } = status;

    public int Likes { get; private set; } = likes;

    public int Dislikes { get; private set; } = dislikes;

    public void Update(string nome, int anoLancamento, string diretor, string status, int likes, int dislikes)
    {
        Nome = nome;
        AnoLancamento = anoLancamento;
        Diretor = diretor;
        Status = status;
        Likes = likes;
        Dislikes = dislikes;
    }
}
