class Podcast
{
    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodios => listaDeEpisodios.Count;
   
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    private List<Episodio> listaDeEpisodios = new();

    public void AdicionarEpisodio(Episodio episodio)
    {
        listaDeEpisodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"\nNome do Podcast: {Nome}| Nome do Host: {Host} \n");
        Console.WriteLine($"Lista de Episódios:  ");
        foreach (Episodio episodio in listaDeEpisodios.OrderBy(e => e.Numero))
        {
            Console.WriteLine(episodio.Resumo);
        }
        //lista de episodios aqui
        Console.WriteLine($"\nTotal de episódios desse Podcast: {TotalEpisodios}");
    }

}