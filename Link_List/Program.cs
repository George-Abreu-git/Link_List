using Link_List.Filters;
using Link_List.Models;
using System.Text.Json;
using TesteAlura.Models.Musica;
public class Program
{


    public static async Task Main()
    {
        HttpClient client = new HttpClient();
        //CadastroArtistas artistas = new CadastroArtistas();
        //DadosIniciais.Carregar(artistas);
        //MenuPrincipal menu = new MenuPrincipal(artistas);
        //menu.Exibir();


        //CatalogoMusicalService catalogoMusical = new CatalogoMusicalService();
        //var mostrarCatalogo = await catalogoMusical.ExibirCatalogo("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");


        var musicasPreferidasGeorge = new MusicasPreferidas("George");



        try
        {



            string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

            var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
            List<Artista> novaLista = new List<Artista>();
            int i = 1;
            foreach (var musica in musicas)
            {
                Artista artistaNovo = new Artista(i, musica.Artista);
                novaLista.Add(artistaNovo);
                i++;
            }

            //musicas[1].ExibirDetalhesDaMusica();

            //foreach (var artista in novaLista)
            //{
            //    Console.WriteLine($"Id: {artista.Id} | Artista: {artista.Nome}");
            //}

            //LinqFilter.FiltrarGeneroMusical(musicas);
            //LinqOrderArtist.ExibirListaArtistasOrdenados(musicas);


            //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "hip hop");


            //LinqFilter.FiltrarMusicasPorArtista(musicas, "50 Cent");

            //musicasPreferidasGeorge.AddMusica(musicas[7]);
            //musicasPreferidasGeorge.AddMusica(musicas[174]);
            //musicasPreferidasGeorge.AddMusica(musicas[29]);
            //musicasPreferidasGeorge.AddMusica(musicas[45]);
            //musicasPreferidasGeorge.AddMusica(musicas[111]);

            //musicasPreferidasGeorge.ExibiListaDeMusicasFavoritas();


            //musicasPreferidasGeorge.GerarArquivoJson();

            LinqFilter.FiltrarKeyDaMusica(musicas);


        }
        catch (Exception ex)
        {
            Console.WriteLine($"Temos um erro inesperado: {ex.Message}");
        }



    }





}
