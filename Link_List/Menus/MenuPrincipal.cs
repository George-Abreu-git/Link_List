using TesteAlura.Cadastros;
using TesteAlura.Interface;
using Link_List.Models;

namespace TesteAlura.Menus
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
               // REVIEW 🟡: O que acontece se o usuário digitar "abc" ou apenas apertar Enter? Qual método de conversão de int não lança exceção e informa se deu certo? (O mesmo vale para os outros menus e para o ID em SelecionarArtista.)
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
           // REVIEW 🔴: O que acontece com o programa se o usuário só apertar Enter aqui? Olhe o setter de Nome em Artista: quem é responsável por tratar o que ele faz quando o valor é inválido?
           cadastro.CadastrarArtistaSolo(nome);
           Console.WriteLine("Artista cadastrado. Pressione qualquer tecla para voltar...");
           Console.ReadKey(true);
       }

       private void SelecionarArtista()
       {
           cadastro.ListarAtrações();
           Console.Write("Digite o ID do artista: ");
           int id = int.Parse(Console.ReadLine());

           if (cadastro.VerificarIdExistente(id, out Artista artistaSelecionado))
           {
               // REVIEW 🟡: Se o ID escolhido for de uma Banda (que herda de Artista), qual menu será aberto aqui? Quem chama CadastrarBanda e quando o MenuBanda seria usado? Como o programa poderia descobrir o tipo real do objeto?
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
