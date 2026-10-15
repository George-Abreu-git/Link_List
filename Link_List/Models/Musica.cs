using System.Text.Json.Serialization;
using Link_List.Models;

namespace Link_List.Models
{
    internal class Musica
    {

        private ArtistaMusicalSolo artista;
        private string nome;
        private int duracao;
        private Genero genero;
         private bool disponivel;


        public Musica(ArtistaMusicalSolo artistaNome, string nomeMusica)
        {
           artista = artistaNome;
           nome = nomeMusica;
        }

        
    
       

        public string Nome
        {
           get => nome;
        }
        public ArtistaMusicalSolo GetArtista
        {
           get => artista;
            
        }
        public string Titulo => $"{nome} - {GetArtista.Nome}";
       
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

        // REVIEW 🟢: Se amanhã a saída deixar de ser o console (ex.: uma API), esta classe de modelo precisaria mudar? Quem deveria ser responsável por "mostrar" e quem por "guardar dados"?
        public static void ExibirMusica(Musica musica)
        {
           Console.WriteLine($"Titulo: {musica.Titulo}");
           Console.WriteLine($"Nome: {musica.Nome}");
           Console.WriteLine($"Artista: {musica.GetArtista.Nome}");
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

        public void ExibirDetalhesDaMusica()
        {
            Console.WriteLine($"Artista: {artista.Nome}");
            Console.WriteLine($"Nome: {Nome}");
            // REVIEW 🟡: O seed usa Duracao = 266 e CalcularDuracaoMusica mostra "4 minutos e 26 segundos". Que texto este ToString("N2") mostra para o mesmo 266? Que unidade a propriedade Duracao guarda, e por que duas telas deveriam mostrar a mesma música de formas diferentes (aqui, em ExibirMusica e em Album.ListarMusicas)?
            Console.WriteLine($"Duração: {(Duracao).ToString("N2")}");
           
        }

        


    }
}
