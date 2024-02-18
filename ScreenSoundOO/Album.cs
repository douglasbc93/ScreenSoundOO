class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome, Gravadora gravadora)
    {
        Nome = nome;
        Gravadora = gravadora;

    }

    public string Nome { get; }
    public Gravadora Gravadora { get; }

    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica (Musica musica)
    {
        musicas.Add (musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Nome} | Duração: {musica.Duracao} segundos.");
        }
        Console.WriteLine($"\nPara ouvir esse álbum inteiro você precisará de {DuracaoTotal} segundos.\n");
    }
}
