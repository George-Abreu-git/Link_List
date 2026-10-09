using System.Text.Json.Serialization;


namespace TesteAlura.Models.Musica
{
    internal class Musica
    {
        //public Musica(Artista artistaNome, string nomeMusica) 
        //{
        //    artista = artistaNome;
        //    nome = nomeMusica;
        //}
        private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };

        [JsonPropertyName("song")]
        public string Nome { get; set; }

        [JsonPropertyName("artist")]
        public string Artista { get; set; }

        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }
        //private bool disponivel;

        [JsonPropertyName("genre")]
        public string Genero { get; set; }

        [JsonPropertyName("key")]
        public int Key { get; set; }

        public string Tonalidade { get { return tonalidades[Key]; } }

        //public string Nome
        //{
        //    get => nome;
        //}
        //public Artista GetArtista
        //{
        //    get => artista;
            
        //}
        //public string Titulo => $"{nome} - {GetArtista.Nome}";
       
        //public int Duracao
        //{
        //    get => duracao;
        //    set => duracao = value;
        //}

        //public bool Disponivel
        //{
        //    get => disponivel;
        //    set => disponivel = value;
        //}

        //public static void ExibirMusica(Musica musica)
        //{
        //    Console.WriteLine($"Titulo: {musica.Titulo}");
        //    Console.WriteLine($"Nome: {musica.nome}");
        //    Console.WriteLine($"Artista: {musica.GetArtista.Nome}");
        //    Console.WriteLine($"Duração: {CalcularDuracaoMusica(musica.duracao)}");
        //    Console.WriteLine($"Disponível: {(musica.disponivel ? "Sim" : "Não")}");
        //}

        //public static string CalcularDuracaoMusica(int duracao)
        //{
        //    int segundosParaMinuto = 60;
        //    int minutos = duracao / segundosParaMinuto;
        //    int segundos = duracao % segundosParaMinuto;
        //    return $"{minutos} minutos e {segundos} segundos";

        //}


        //public void AlterarNomeDaMusica( String novoNome)
        //{
        //    nome = novoNome;
        //}
        //public void AlterarGeneroMusica( Genero novoGenero)
        //{
        //    genero = novoGenero;
        //}

        public void ExibirDetalhesDaMusica()
        {
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Duração: {(Duracao * 0.00001666667).ToString("N2")}");
            Console.WriteLine($"Gênero: {Genero}\n");
            Console.WriteLine($"Tonalidade: {Tonalidade}\n");
        }

        


    }
}
