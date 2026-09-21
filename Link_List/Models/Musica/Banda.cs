using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAlura.Models.Musica
{
    internal class Banda : Artista
    {
        public Banda(int id, string nome) : base(id, nome)
        {
            
        }

        private List<Artista> integrantes = new List<Artista>();


        public void AdicionarIntegrante(Artista nomeIntegrante)
        {
            integrantes.Add(nomeIntegrante);
        }

        public void ListarIntegrantes()
        {
            foreach (Artista integrante in integrantes)
            {
                Console.WriteLine(integrante);
            }
        }
    }
}
