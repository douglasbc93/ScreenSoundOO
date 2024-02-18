
class Episodio
{
    public List<string> convidados = new();
    public Episodio(int numero, string titulo, int duracao)
    {
        Numero = numero;
        Titulo = titulo;
        Duracao = duracao;
    }

    public int Numero { get; }
    public string Titulo { get; }
    public int Duracao { get; }
    public string Resumo => $"{Numero}. Título: {Titulo} | " +
        $"Duração: {Duracao} minutos | Convidados: {string.Join(", ", convidados)}. ";

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }

}