
//ITENS REFERENTES AO CURSO:

Banda bmth = new Banda();
bmth.NomeBanda = "Bring Me The Horizon";
Genero rock = new Genero("Rock");
Gravadora sonyColumbiaRrca = new Gravadora("Sony, Columbia e RCA");

Album albumBmth1 = new Album("That's the Spirit", sonyColumbiaRrca);

Musica musica1 = new Musica(bmth, "Doomed", rock, 274, false);
Musica musica2 = new Musica(bmth, "Happy Song", rock, 239, false);
Musica musica3 = new Musica(bmth, "Throne", rock, 191, true);
Musica musica4 = new Musica(bmth, "True Friends", rock, 232, true);
Musica musica5 = new Musica(bmth, "Follow You", rock, 231, true);
Musica musica6 = new Musica(bmth, "What You Need", rock, 252, true);
Musica musica7 = new Musica(bmth, "Avalanche", rock, 262, true);
Musica musica8 = new Musica(bmth, "Run", rock, 222, true);
Musica musica9 = new Musica(bmth, "Drown", rock, 222, false);
Musica musica10 = new Musica(bmth, "Blasphemy", rock, 275, true);
Musica musica11 = new Musica(bmth, "Oh No", rock, 301, true);

albumBmth1.AdicionarMusica(musica1);
albumBmth1.AdicionarMusica(musica2);
albumBmth1.AdicionarMusica(musica3);
albumBmth1.AdicionarMusica(musica4);
albumBmth1.AdicionarMusica(musica5);
albumBmth1.AdicionarMusica(musica6);
albumBmth1.AdicionarMusica(musica7);
albumBmth1.AdicionarMusica(musica8);
albumBmth1.AdicionarMusica(musica9);
albumBmth1.AdicionarMusica(musica10);
albumBmth1.AdicionarMusica(musica11);

bmth.AdicionarAlbum(albumBmth1);
bmth.ExibirDiscografia();

albumBmth1.ExibirMusicasDoAlbum();

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
musica3.ExibirFichaTecnica();
musica4.ExibirFichaTecnica();
musica5.ExibirFichaTecnica();
musica6.ExibirFichaTecnica();
musica7.ExibirFichaTecnica();
musica8.ExibirFichaTecnica();
musica9.ExibirFichaTecnica();
musica10.ExibirFichaTecnica();
musica11.ExibirFichaTecnica();


// ITENS REFERNTES AO DESAFIO:

Episodio episodio1 = new(1, "Episódio 1 - Iniciando em C#", 60);
episodio1.AdicionarConvidados("Douglas");

Episodio episodio2 = new(2, "Episódio 2 - C# Orientado a Objetos", 80);
episodio2.AdicionarConvidados("Daniel");

Console.WriteLine(episodio1.Resumo);
Console.WriteLine(episodio2.Resumo);

Podcast podcast1 = new("Curso de C#", "Alura");
podcast1.AdicionarEpisodio(episodio1);
podcast1.AdicionarEpisodio(episodio2);

podcast1.ExibirDetalhes();
