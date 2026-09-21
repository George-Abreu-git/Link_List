using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAlura.Cadastros;
using TesteAlura.Interface;
using TesteAlura.Menus;
using TesteAlura.Models.Musica;

namespace Link_List.Menus
{
    internal class MenuAlbumSelecionado : IMenu
    {
        private Artista artista;
        private CadastroArtistas cadastro;
        private Album album;

        public MenuAlbumSelecionado(Album albumSelecionado, Artista artistaSelecionado)
        {
            this.album = albumSelecionado;
            this.artista = artistaSelecionado;
        }
        public void Exibir()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Album: {album.Nome}\n");
                Console.WriteLine("1 - Exibir detalhes");
                Console.WriteLine("2 - Gerenciar musicas");
                Console.WriteLine("3 - Excluir album");
                Console.WriteLine("0 - Voltar");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        return;
                    case 1:
                        Console.WriteLine($"Nome: {album.Nome}");
                        album.ListarMusicas();
                        Console.WriteLine("Pressione qualquer tecla para voltar...");
                        Console.ReadKey(true);
                        break;
                    case 2:
                        //menuMusicas.Exibir();
                        break;
                    case 3:
                        artista.RemoverAlbum(album);
                        Console.WriteLine($"Album {album.Nome} excluído.");
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
