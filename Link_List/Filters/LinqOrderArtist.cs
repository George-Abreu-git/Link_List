using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAlura.Models.Musica;

namespace Link_List.Filters
{
    internal class LinqOrderArtist
    {
        public static void ExibirListaArtistasOrdenados(List<Musica> musicas)
        {
            var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();

            foreach(var musica in artistasOrdenados)
            {
                Console.WriteLine($"Artista: {musica}");
            }
        }
    }
}
