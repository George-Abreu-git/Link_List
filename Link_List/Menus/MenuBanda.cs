using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAlura.Cadastros;
using TesteAlura.Interface;
using TesteAlura.Models.Musica;

namespace TesteAlura.Menus
{
    internal class MenuBanda : IMenu
    {
        private Banda banda;
        private CadastroArtistas cadastro;
        private int idBanda;

        private MenuAlbum menuAlbum;
        public MenuBanda (
            Banda bandaSelecionada,
            CadastroArtistas cadastro,
            int idBanda
            )
        {
            banda = bandaSelecionada;
            this.cadastro = cadastro;
            this.idBanda = idBanda;
            menuAlbum = new MenuAlbum(banda );
        }

        public void Exibir()
        {
            int opcaoEscolhida;

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Menu da Banda {banda.Nome}\n");

                Console.WriteLine("1 - Gerenciar Integrantes\n");
                Console.WriteLine("2 - Gerenciar Albuns\n");
                Console.WriteLine("3 - Excluir Banda\n");
                Console.WriteLine("0 - Voltar\n");
                opcaoEscolhida = int.Parse(Console.ReadLine());

                switch (opcaoEscolhida)
                {
                    case 0:
                        Console.WriteLine("Voltando ao menu principal...");
                        Thread.Sleep(2500);
                        return;
                    case 1:
                        
                        break;
                    case 2:
                        menuAlbum.Exibir();
                        Console.WriteLine("Pressione qualquer tecla para voltar: ");
                        Console.ReadKey(true);
                        break;
                    case 3:
                        cadastro.ExcluirArtista(idBanda);
                        Console.WriteLine("Excluindo banda...");
                        Thread.Sleep(2000);
                        Console.WriteLine($"Banda {banda.Nome} excluida");
                        Thread.Sleep(1500);
                        return;
                    default:
                        Console.WriteLine("Digite uma opção válida");
                        break;


                }
            }
        }

    }
}
