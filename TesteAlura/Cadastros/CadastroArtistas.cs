using TesteAlura.Models.Musica;

namespace TesteAlura.Cadastros
{
    internal class CadastroArtistas
    {
        private List<Artista> artistas = new List<Artista>();
        private int proxId = 1;

        public Artista CadastrarArtistaSolo(string nome)
        {
            Artista artista = new Artista(proxId, nome);
            artistas.Add(artista);
            proxId++;
            return artista;
        }

        public void ExcluirArtista(int id)
        {
            if (VerificarIdExistente(id, out Artista artista))
            {
                artistas.Remove(artista);
            }
        }

        public void ListarAtrações()
        {
            foreach (Artista registro in artistas)
            {
                Console.WriteLine($"{registro.Id} - {registro.Nome}\n");
            }
        }

        public bool VerificarIdExistente(int id, out Artista artista)
        {
            foreach (Artista artistaCadastrado in artistas)
            {
                if (artistaCadastrado.Id == id)
                {
                    artista = artistaCadastrado;
                    return true;
                }
            }

            artista = null;
            return false;
        }

        public Banda CadastrarBanda(string nome)
        {
            Banda banda = new Banda(proxId, nome);

            artistas.Add(banda);
            proxId++;
            return banda;
        }
    }
}
