namespace MoviesApi.ViewModels.Movies;

public class GetMovieByIdViewModel(string nome, int anoLancamento, string diretor, int likes, int dislikes)
{
    public string Nome { get; private set; } = nome;

    public int AnoLancamento { get; private set; } = anoLancamento;

    public string Diretor { get; private set; } = diretor;

    public int Likes { get; private set; } = likes;

    public int Dislikes { get; private set; } = dislikes;
}
