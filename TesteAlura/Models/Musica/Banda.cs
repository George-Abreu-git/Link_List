using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAlura.Models.Musica
{
    internal class Banda : Artista
    {
        public Banda(string nome) : base(nome)
        {

        }

        private List<string> integrantes = new List<string>();


        public void AdicionarIntegrante(string nomeIntegrante)
        {
            integrantes.Add(nomeIntegrante);
        }

        public void ListarIntegrantes()
        {
            foreach (string integrante in integrantes)
            {
                Console.WriteLine(integrante);
            }
        }
    }
}
