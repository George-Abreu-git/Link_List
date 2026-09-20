namespace TesteAlura.Models.Musica
{
    internal class Musica
    {
        public Musica(Artista artistaNome, string nomeMusica) 
        {
            artista = artistaNome;
            nome = nomeMusica;
        }

        private string nome;
        private Artista artista;
        private int duracao;
        private bool disponivel;

        private Genero genero;

        public string Nome
        {
            get => nome;
        }
        public Artista Artista
        {
            get => artista;
            
        }
        public string Titulo => $"{nome} - {Artista.Nome}";
       
        public int Duracao
        {
            get => duracao;
            set => duracao = value;
        }

        public bool Disponivel
        {
            get => disponivel;
            set => disponivel = value;
        }

        public static void ExibirMusica(Musica musica)
        {
            Console.WriteLine($"Titulo: {musica.Titulo}");
            Console.WriteLine($"Nome: {musica.nome}");
            Console.WriteLine($"Artista: {musica.Artista.Nome}");
            Console.WriteLine($"Duração: {CalcularDuracaoMusica(musica.duracao)}");
            Console.WriteLine($"Disponível: {(musica.disponivel ? "Sim" : "Não")}");
        }

        public static string CalcularDuracaoMusica(int duracao)
        {
            int segundosParaMinuto = 60;
            int minutos = duracao / segundosParaMinuto;
            int segundos = duracao % segundosParaMinuto;
            return $"{minutos} minutos e {segundos} segundos";

        }


        public void AlterarNomeDaMusica( String novoNome)
        {
            nome = novoNome;
        }
        public void AlterarGeneroMusica( Genero novoGenero)
        {
            genero = novoGenero;
        }


    }
}
