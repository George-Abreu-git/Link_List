using TesteAlura.Models.Musica;

namespace Link_List.Filters
{
    internal class LinqFilter
    {
        public static void FiltrarGeneroMusical(List<Musica> musicas)
        {
            var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();

            foreach (var genero in todosOsGenerosMusicais)
            {
                Console.WriteLine($"Genero: {genero}\n");
            }
        }


        public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
        {
            var artistaPorGeneroMusical = musicas.Where(musica => musica.Genero.Contains(genero)).Select(musica => musica.Artista).ToList().Distinct();

            Console.WriteLine($"Exibindo os artistas por gênero musical >>>>> {genero}");

            foreach (var artista in artistaPorGeneroMusical)
            {
                Console.WriteLine($"- {artista}");
            }
        }

        public static void FiltrarMusicasPorArtista(List<Musica> musicas, string artista)
        {
            var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(artista)).ToList().Distinct();

            Console.WriteLine(artista);

            foreach(var musica in musicasDoArtista)
            {
                Console.WriteLine($"- {musica.Nome}");
            }
        }

        public static void FiltrarKeyDaMusica(List<Musica> musicas)
        {
            var keyDaMusica = musicas.Where(musica => musica.Tonalidade.Equals("C#")).ToList().Distinct();

            foreach(var musica in keyDaMusica)
            {
                Console.WriteLine($"- {musica.Nome} - {musica.Tonalidade}");
            }
        }

    }
}
