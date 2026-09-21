using TesteAlura.Cadastros;
using TesteAlura.Models.Musica;

namespace TesteAlura.Seeds
{
    internal static class DadosIniciais
    {
        // Carregue uma vez por cadastro. Durações aproximadas; disponibilidade fictícia.
        public static void Carregar(CadastroArtistas cadastro)
        {
            Genero industrial = new Genero { Nome = "Rock industrial" };

            Artista manson = cadastro.CadastrarArtistaSolo("Marilyn Manson");
            Album mansonAlbum = new Album("The Pale Emperor");
            mansonAlbum.AnoLancamento = 2015;

            Musica mansonMusica1 = new Musica(manson, "Third Day of a Seven Day Binge");
            mansonMusica1.Duracao = 266;
            mansonMusica1.Disponivel = true;
            mansonMusica1.AlterarGeneroMusica(industrial);
            mansonAlbum.AdicionarMusica(mansonMusica1);

            Musica mansonMusica2 = new Musica(manson, "Deep Six");
            mansonMusica2.Duracao = 302;
            mansonMusica2.Disponivel = false;
            mansonMusica2.AlterarGeneroMusica(industrial);
            mansonAlbum.AdicionarMusica(mansonMusica2);
            manson.AdicionarAlbum(mansonAlbum);
        }
    }
}