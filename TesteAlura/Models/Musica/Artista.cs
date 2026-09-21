namespace TesteAlura.Models.Musica
{
    internal class Artista
    {

        public Artista(int id, string nome)
        {
            this.id = id;
            Nome = nome;

        }

        private int id;
        public int Id => id;
        private string nome;
        private double avaliacao;
        private List<Album> albuns = new List<Album>();
        private bool artistaRegistrado;
        private Genero generoMusical;

        public string Nome
        {
            get => nome;

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O nome do artista não pode ser nulo ou vazio.");
                }
                nome = value;
            }
        }

        public double Nota
        {
            get => avaliacao;

            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("A avaliacao do artista deve estar entre 0 e 10.");
                }
                avaliacao = value;
            }
        }


        public void AdicionarAlbum(Album novoAlbum)
        {
            
            albuns.Add(novoAlbum);
        }

        public void RemoverAlbum(Album novoAlbum)
        {

            albuns.Remove(novoAlbum);
        }

        public void ListarAlbuns()
        {
            Console.WriteLine($"Álbuns do artista: {Nome}\n");
            foreach (Album album in albuns)
            {
                if (albuns.Count == 0)
                {
                    Console.WriteLine("Nenhum álbum cadastrado.");
                    return;
                }
                else if (albuns.LastIndexOf(album) == albuns.Count - 1)
                {
                    Console.WriteLine($"Nome: {album.Nome}\n");
                }
                else
                {
                    Console.WriteLine($"Nome: {album.Nome}");
                }
            }
        }
        public Album BuscarAlbumPorNome(string nome)
        {
            foreach (Album album in albuns)
            {
                if (album.Nome == nome)
                {
                    return album;
                }
            }

            return null;
        }
    }
}


