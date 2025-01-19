namespace MoviesApi.Dtos.Movies;

public class CreateMovieDto
{
    public string Nome { get; set; }

    public int Ano_Lancamento { get; set; }

    public string Diretor { get; set; }

    public int Likes { get; set; }

    public int Dislikes { get; set; }
}
