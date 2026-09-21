using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAlura.Models.Musica
{
    internal class Album
    {
        public Album (string nome)
        {
            Nome = nome;
        }
        public string Nome { get;}
        public int AnoLancamento { get; set; }
        private List<Musica> musicas = new List<Musica>();
        public int DuracaoTotal => musicas.Sum(musica => musica.Duracao);

        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
        }

        public void RemoverMusica(Musica musica)
        {
            musicas.Remove(musica);
        }

        public void ListarMusicas()
        {
            Console.WriteLine($"Músicas do álbum: {Nome}\n");
            foreach (Musica musica in musicas)
            {
                if (musicas.Count == 0)
                {
                    Console.WriteLine("Nenhuma música cadastrada.");
                    return;
                }
                else if (musicas.LastIndexOf(musica) == musicas.Count - 1)
                {
                    Console.WriteLine($"Musica: {musica.Nome}\n");
                }
                else
                {
                    Console.WriteLine($"Musica: {musica.Nome}");
                }
            }

            Console.WriteLine($"Duração total do álbum: {DuracaoTotal} segundos\n");

            foreach(Musica musica in musicas)
            {
                Musica.ExibirMusica(musica);
            }

        }

        
    }
}
