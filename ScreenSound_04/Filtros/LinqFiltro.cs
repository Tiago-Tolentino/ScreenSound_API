using ScreenSound_04.Modelos;
using System.Linq;

namespace ScreenSound_04.Filtros;

internal class LinqFiltro
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine(genero);
        }
    }

    public static void FiltrarArtistaPorGeneroMusical(List<Musica> musicas, string genero) 
    { 
        var artistasPorGeneroMusical = musicas.Where(musicas => musicas.Genero.Contains(genero)).Select(musicas => musicas.Artista).Distinct().ToList();
        foreach(var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine(artista);
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musicas => musicas.Artista!.Equals(nomeDoArtista)).ToList();
        foreach(var musica in musicasDoArtista)
        {
            Console.WriteLine(musica.Nome);
        }
    }
    public static void FiltrarMusicasPorKey(List<Musica> musicas, int keyDaMusica)
    {
        var tonalidadeMusica = musicas.Where(musicas =>musicas.Key!.Equals(keyDaMusica)).ToList();
        foreach (var musica in tonalidadeMusica)
        {
            Console.WriteLine(musica.Nome);
        }
    }
}
