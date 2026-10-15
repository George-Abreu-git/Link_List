//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Link_List.Cadastros;
//using Link_List.Interface;
//using Link_List.Models;

//namespace Link_List.Menus
//{
//   internal class MenuBanda : IMenu
//   {
//       private Banda banda;
//       private CadastroArtistas cadastro;


//       private MenuAlbum menuAlbum;
//       public MenuBanda (
//           Banda bandaSelecionada,
//           CadastroArtistas cadastro,
//           // REVIEW 🟡: A Banda recebida no construtor já não carrega o próprio Id? Por que receber o id separado aqui (e o "cadastro" em MenuAlbum/MenuAlbumSelecionado, e idArtista em MenuAlbum, que nunca são usados)?
//           int idBanda
//           )
//       {
//           banda = bandaSelecionada;
//           this.cadastro = cadastro;
//           menuAlbum = new MenuAlbum(banda );
//       }

//       public void Exibir()
//       {
//           int opcaoEscolhida;

//           while (true)
//           {
//               Console.Clear();
//               Console.WriteLine($"Menu da Banda {banda.Nome}\n");

//               Console.WriteLine("1 - Gerenciar Integrantes\n");
//               Console.WriteLine("2 - Gerenciar Albuns\n");
//               Console.WriteLine("3 - Excluir Banda\n");
//               Console.WriteLine("0 - Voltar\n");
//               opcaoEscolhida = int.Parse(Console.ReadLine());

//               switch (opcaoEscolhida)
//               {
//                   case 0:
//                       Console.WriteLine("Voltando ao menu principal...");
//                       Thread.Sleep(2500);
//                       return;
//                   case 1:
                        
//                       break;
//                   case 2:
//                       menuAlbum.Exibir();
//                       Console.WriteLine("Pressione qualquer tecla para voltar: ");
//                       Console.ReadKey(true);
//                       break;
//                   case 3:
//                       cadastro.ExcluirArtista(banda.Id);
//                       Console.WriteLine("Excluindo banda...");
//                       Thread.Sleep(2000);
//                       Console.WriteLine($"Banda {banda.Nome} excluida");
//                       Thread.Sleep(1500);
//                       return;
//                   default:
//                       Console.WriteLine("Digite uma opção válida");
//                       break;


//               }
//           }
//       }

//   }
//}
