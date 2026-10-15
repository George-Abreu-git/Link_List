using Link_List.Models;

namespace Link_List.Models
{
    internal class ArtistaMusicalSolo 
    {

        public ArtistaMusicalSolo(int id, string nome)
        {
            this.id = id;
            Nome = nome;

        }

        private int id;
        private string nome;
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

        public int Id => id;
        //public double Nota
        //{
        //    get => avaliacao;

        //    set
        //    {
        //        if (value < 0 || value > 10)
        //        {
        //            // REVIEW 🟢: Qual é o primeiro parâmetro do construtor de ArgumentOutOfRangeException com uma única string: o nome do parâmetro ou a mensagem? Confira na documentação e veja como sua mensagem aparece quando a exceção é lançada.
        //            throw new ArgumentOutOfRangeException("A avaliacao do artista deve estar entre 0 e 10.");
        //        }
        //        avaliacao = value;
        //    }
        //}


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

                // REVIEW 🟡: Se a lista de álbuns estiver vazia, quantas vezes o corpo do foreach é executado? Então, se você quisesse avisar "Nenhum álbum cadastrado.", onde essa checagem deveria ficar em relação ao laço?
                if (albuns.LastIndexOf(album) == albuns.Count - 1)
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



