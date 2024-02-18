class Musica
{
    public Musica(Banda artista, string nome, Genero genero, int duracao, bool disponivel)
    {
        Artista = artista;
        Nome = nome;
        Genero = genero;
        Duracao = duracao;
        Disponivel = disponivel; 
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao {  get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}.\n";
    public Genero Genero { get; }


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.NomeBanda}");
        Console.WriteLine($"Gênero: {Genero.NomeGenero}");
        Console.WriteLine($"Duração: {Duracao} segundos");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.\n");
        }
        else
        {
            Console.WriteLine("Adquira o plano Premium.\n");
        }

    }
}