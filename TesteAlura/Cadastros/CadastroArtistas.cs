using TesteAlura.Menus;
using TesteAlura.Models.Musica;


namespace TesteAlura.Cadastros
{
    internal class CadastroArtistas
    {
        private Dictionary<int, Artista> artistas = new Dictionary<int, Artista>();

        private int proxId = 1;

        
        public Banda CadastrarBanda(string nome)
        {
            Banda banda = new Banda(nome);

            artistas.Add(proxId, banda);
            proxId++;
            return banda;
        }

        public void ListarBandas()
        {
            foreach (KeyValuePair<int, Artista> artista in artistas)
            {
                if (artista.Value is Banda)
                    Console.WriteLine($"{artista.Key} - {artista.Value.Nome}");
            }
        }

        public void ExcluirBanda(int id)
        { 
            artistas.Remove(id);
        }

        public Artista CadastrarArtistaSolo(string nome)
        {
            Artista artista = new Artista(nome);
            artistas.Add(proxId, artista);
            proxId++;
            return artista;
        }

        public void ListarArtistas()
        {

            foreach (KeyValuePair<int, Artista> registro in artistas)
            {
                string tipo = registro.Value is Banda ? "Banda" : "Artista solo";
                Console.WriteLine($"{registro.Key} - {registro.Value.Nome} ({tipo})\n");

            }

        }


       
        public bool VerificarIdExistente(int id, out Artista artista)
        {
            return artistas.TryGetValue(id, out artista);
        }



    }
}
