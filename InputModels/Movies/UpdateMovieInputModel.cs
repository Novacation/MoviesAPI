namespace MoviesApi.InputModels.Movies;

public class UpdateMovieInputModel(
    int id,
    string nome,
    int anoLancamento,
    string diretor,
    string status,
    int likes,
    int dislikes)
{
    public int Id { get; init; } = id;
    public string Nome { get; init; } = nome;

    public int AnoLancamento { get; init; } = anoLancamento;

    public string Diretor { get; init; } = diretor;

    public string Status { get; init; } = status;

    public int Likes { get; init; } = likes;

    public int Dislikes { get; init; } = dislikes;
}
