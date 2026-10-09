using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using TesteAlura.Models.Musica;

namespace Link_List.Models
{
    internal class MusicasPreferidas
    {
        public string Nome { get; }

        public List<Musica> ListaDeMusicasFavoritas { get; }

        public MusicasPreferidas(string nome)
        {
            Nome = nome;

            ListaDeMusicasFavoritas = new List<Musica>();
        }

        public void AddMusica(Musica musica)
        {
            ListaDeMusicasFavoritas.Add(musica);
        }

        public void ExibiListaDeMusicasFavoritas()
        {
            Console.WriteLine($"Essas são as musicas favoritas de {Nome}");
            foreach (var musica in ListaDeMusicasFavoritas)
            {
                Console.WriteLine($"- {musica.Artista} - {musica.Nome}");
            }
        }

        public void GerarArquivoJson()
        {
            string json = JsonSerializer.Serialize(new
            {
                nome = Nome,
                musicas = ListaDeMusicasFavoritas
            });
            string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";

            File.WriteAllText(nomeDoArquivo, json);

            Console.WriteLine($"O aqruivo {nomeDoArquivo} foi gerado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
        }
    }
}
