using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAlura.Interface;
using TesteAlura.Cadastros;
using TesteAlura.Menus;
using TesteAlura.Models.Musica;
using TesteAlura.Seeds;
using System.Reflection.Metadata;

namespace TesteAlura.Menus
{
    internal class MenuArtistas : IMenu
    {
        private CadastroArtistas cadastro;

        public MenuArtistas(CadastroArtistas novoCadastro)
        {
            cadastro = novoCadastro;
        }
       
        public void Exibir()
        {
            
            int opcaoEscolhida;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Boas Vindas ao Screen Sound\n");

                Console.WriteLine("1 - Cadastrar Artista\n");
                Console.WriteLine("2 - Listar Artistas\n");
                Console.WriteLine("3 - Selecionar Artista\n");
                Console.WriteLine("0 - Voltar\n");
                opcaoEscolhida = int.Parse(Console.ReadLine());

                switch (opcaoEscolhida)
                {
                    case 0:
                        Console.WriteLine("Encerrando programa...");
                        Thread.Sleep(2500);
                        return;                        
                    case 1:
                        EscolheQualTipoCadastrar();                 
                        break;
                    case 2:
                        cadastro.ListarArtistas();
                        Console.WriteLine("Pressione qualquer tecla para voltar: ");
                        Console.ReadKey(true);
                        break;
                    case 3:
                        SelecionarArtista();
                        break;
                    default:
                        Console.WriteLine("Digite uma opção válida");
                        break;


                }
            }
 
        }

        public void EscolheQualTipoCadastrar()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Qual o tipo de artista deseja cadastrar: \n");
                Console.WriteLine("1 - Artista Solo\n");
                Console.WriteLine("2 - Banda\n");
                Console.WriteLine("0 - Voltar\n");
                int opcaoDigitada = int.Parse(Console.ReadLine());


                switch(opcaoDigitada)
                {
                    case 0:
                        return;
                    case 1:
                        Console.WriteLine("Digite o nome do artista: ");
                        string nomeArtista = Console.ReadLine();
                        cadastro.CadastrarArtistaSolo(nomeArtista);
                        break;
                    case 2:
                        Console.WriteLine("Digite o nome da banda: ");
                        nomeArtista = Console.ReadLine();
                        cadastro.CadastrarBanda(nomeArtista);
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

              
            }
        }

         public void SelecionarArtista()
        {
            cadastro.ListarArtistas();
            Console.WriteLine("Digite o número do artista: ");
            int idDigitado = int.Parse(Console.ReadLine());

            
            if (cadastro.VerificarIdExistente(idDigitado, out Artista artistaSelecionado))
            {

                if (artistaSelecionado is Banda banda)
                {
                    Console.WriteLine($"Banda selecionada: {artistaSelecionado.Nome}\n");
                    MenuBanda menu = new MenuBanda(banda, cadastro, idDigitado);
                    menu.Exibir();
                    Console.WriteLine("Digite uma tecla para voltar:");
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine($"Artista selecionado: {artistaSelecionado.Nome}\n");
                    Console.WriteLine("Digite uma tecla para voltar:");
                    Console.ReadKey(true);
                    //ExibirMenuArtistaSolo();
                }
            } else
            {
                Console.WriteLine("Digite um artista válido");
            }
 



        }
    }
}
