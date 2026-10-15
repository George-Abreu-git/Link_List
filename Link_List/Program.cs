using Link_List.Models;
using Link_List.Menus;
using Link_List.Cadastros;
using Link_List.Seeds;

public class Program
{
    public static void Main()
    {
        CadastroArtistas cadastro = new CadastroArtistas();
        DadosIniciais.Carregar(cadastro);
        MenuPrincipal menu = new MenuPrincipal(cadastro);
        menu.Exibir();
    }
}
