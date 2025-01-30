namespace MoviesApi.InputModels.Movies;

public class CreateMovieInputModel(string nome, int anoLancamento, string diretor, int likes, int dislikes)
{
    public string Nome { get; init; } = nome;

    public int Ano_Lancamento { get; init; } = anoLancamento;

    public string Diretor { get; init; } = diretor;

    public int Likes { get; init; } = likes;

    public int Dislikes { get; init; } = dislikes;
}
