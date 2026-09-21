using TesteAlura.Cadastros;
using TesteAlura.Interface;
using TesteAlura.Models.Musica;

namespace TesteAlura.Menus
{
    internal class MenuArtista : IMenu
    {
        private Artista artista;
        private CadastroArtistas cadastro;
        private MenuAlbum menuAlbum;

        public MenuArtista(Artista artistaSelecionado, CadastroArtistas cadastro)
        {
            artista = artistaSelecionado;
            this.cadastro = cadastro;
            menuAlbum = new MenuAlbum(artista);
        }

        public void Exibir()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Artista: {artista.Nome}\n");
                Console.WriteLine("1 - Exibir detalhes");
                Console.WriteLine("2 - Gerenciar álbuns");
                Console.WriteLine("3 - Excluir artista");
                Console.WriteLine("0 - Voltar");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        return;
                    case 1:
                        Console.WriteLine($"ID: {artista.Id}");
                        Console.WriteLine($"Nome: {artista.Nome}");
                        artista.ListarAlbuns();
                        Console.WriteLine("Pressione qualquer tecla para voltar...");
                        Console.ReadKey(true);
                        break;
                    case 2:
                        menuAlbum.Exibir();
                        break;
                    case 3:
                        cadastro.ExcluirArtista(artista.Id);
                        Console.WriteLine($"Artista {artista.Nome} excluído.");
                        Console.ReadKey(true);
                        return;
                    default:
                        Console.WriteLine("Digite uma opção válida.");
                        Console.ReadKey(true);
                        break;
                }
            }
        }
    }
}
