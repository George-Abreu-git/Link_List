using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Link_List.Models;

namespace Link_List.Models
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
               // REVIEW 🟡: Mesma dúvida do Artista.ListarAlbuns: com a lista vazia, este if chega a ser executado? E o "Duração total" lá embaixo, o que acontece nesse caso?
              if (musicas.LastIndexOf(musica) == musicas.Count - 1)
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
