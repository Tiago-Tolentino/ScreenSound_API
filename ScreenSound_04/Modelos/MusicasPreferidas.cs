using System.Threading.Channels;
using System.Text.Json;

namespace ScreenSound_04.Modelos;

internal class MusicasPreferidas
{
    public List<Musica> ListaDeMusicasFavoritas { get; }
    public string Nome { get; set; }


    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }

    public void AdiconarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas sao as musicas favoritas");
        foreach (var musica in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
        Console.WriteLine();
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas
        });
        string nomeDoArquivo = $"musica-favoritas{Nome}.json";

        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"Json foi criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
    }
    
}
