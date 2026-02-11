using ScreenSound_04.Modelos;
using System.Text.Json;
using ScreenSound_04.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFiltro.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrdem.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFiltro.FiltrarArtistaPorGeneroMusical(musicas, "rock");
        //LinqFiltro.FiltrarMusicasDeUmArtista(musicas, "Will Smith");
        LinqFiltro.FiltrarMusicasPorKey(musicas, 1);

        //var musicasPreferidas = new MusicasPreferidas("Me");
        //musicasPreferidas.AdiconarMusicasFavoritas(musicas[1]);
        //musicasPreferidas.AdiconarMusicasFavoritas(musicas[24]);
        //musicasPreferidas.AdiconarMusicasFavoritas(musicas[1995]);
        //musicasPreferidas.AdiconarMusicasFavoritas(musicas[679]);
        //musicasPreferidas.AdiconarMusicasFavoritas(musicas[1326]);

        //musicasPreferidas.ExibirMusicasFavoritas();

        //musicasPreferidas.GerarArquivoJson();



    }
    catch (Exception ex) 
    {
        Console.WriteLine(ex.Message);
    }
   
}