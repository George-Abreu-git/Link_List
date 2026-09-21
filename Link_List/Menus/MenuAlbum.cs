using Link_List.Menus;
using TesteAlura.Cadastros;
using TesteAlura.Interface;
using TesteAlura.Models.Musica;

namespace TesteAlura.Menus
{
    internal class MenuAlbum : IMenu
    {

        private CadastroArtistas cadastro;
        private int idArtista;
        private Artista artista;
        
        public MenuAlbum(Artista artistaSelecionado)
        {
            artista = artistaSelecionado;
            
        }

        public void Exibir()
        {
            int opcaoEscolhida;

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Álbuns de {artista.Nome}\n");

                Console.WriteLine("1 - Cadastrar Album\n");
                Console.WriteLine("2 - Listar Albuns\n");
                Console.WriteLine("3 - Selecionar Album\n");
                Console.WriteLine("0 - Voltar\n");
                opcaoEscolhida = int.Parse(Console.ReadLine());

                switch (opcaoEscolhida)
                {
                    case 0:
                        Console.WriteLine($"Voltando ao menu de {artista.Nome}...");
                        Thread.Sleep(2500);
                        return;
                    case 1:
                        Console.WriteLine("Digite o nome do Album: ");
                        String digitarAlbumNovo = Console.ReadLine();
                        Album albumNovo = new Album(digitarAlbumNovo);
                        artista.AdicionarAlbum(albumNovo);
                        Console.WriteLine($"Album {albumNovo.Nome} adicionado");
                        Thread.Sleep(2000);
                        break;
                    case 2:
                        artista.ListarAlbuns();
                        Console.WriteLine("Pressione qualquer tecla para voltar: ");
                        Console.ReadKey(true);
                        break;
                    case 3:
                        SelecionarAlbum();
                        break;
                    default:
                        Console.WriteLine("Digite uma opção válida");
                        break;
                }



            }
        }

        public void SelecionarAlbum()
        {
            artista.ListarAlbuns();

            Console.Write("Digite o nome do álbum que deseja selecionar: ");
            string nomeAlbum = Console.ReadLine();

            Album albumSelecionado = artista.BuscarAlbumPorNome(nomeAlbum);

            if (albumSelecionado != null)
            {
                MenuAlbumSelecionado menuAlbumSelecionado = new MenuAlbumSelecionado(albumSelecionado, artista);
                menuAlbumSelecionado.Exibir();
    }
            else
            {
                Console.WriteLine("Álbum não encontrado.");
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey(true);
        }
    }
}


