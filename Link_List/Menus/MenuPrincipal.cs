using Link_List.Cadastros;
using Link_List.Interface;
using Link_List.Models;

namespace Link_List.Menus
{
   internal class MenuPrincipal : IMenu
   {
       private CadastroArtistas cadastro;

       public MenuPrincipal(CadastroArtistas novoCadastro)
       {
           cadastro = novoCadastro;
       }

       public void Exibir()
       {
           while (true)
           {
               Console.Clear();
               Console.WriteLine("Boas-vindas ao LinkList!\n");
               Console.WriteLine("1 - Cadastrar artista");
               Console.WriteLine("2 - Listar artistas");
               Console.WriteLine("3 - Selecionar artista");
               Console.WriteLine("0 - Sair");
               int opcao = int.Parse(Console.ReadLine());

               switch (opcao)
               {
                   case 0:
                       return;
                   case 1:
                       CadastrarArtista();
                       break;
                   case 2:
                       cadastro.ListarAtrações();
                       Console.WriteLine("Pressione qualquer tecla para voltar...");
                       Console.ReadKey(true);
                       break;
                   case 3:
                       SelecionarArtista();
                       break;
                   default:
                       Console.WriteLine("Digite uma opção válida.");
                       Console.ReadKey(true);
                       break;
               }
           }
       }

       private void CadastrarArtista()
       {
           Console.Write("Digite o nome do artista: ");
           string nome = Console.ReadLine();
           cadastro.CadastrarArtistaSolo(nome);
           Console.WriteLine("Artista cadastrado. Pressione qualquer tecla para voltar...");
           Console.ReadKey(true);
       }

       private void SelecionarArtista()
       {
           cadastro.ListarAtrações();
           Console.Write("Digite o ID do artista: ");
           int id = int.Parse(Console.ReadLine());

           if (cadastro.VerificarIdExistente(id, out ArtistaMusicalSolo artistaSelecionado))
           {
               MenuArtista menu = new MenuArtista(artistaSelecionado, cadastro);
               menu.Exibir();
           }
           else
           {
               Console.WriteLine("Não existe um artista com esse ID.");
               Console.ReadKey(true);
           }
       }
   }
}
