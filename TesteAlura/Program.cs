using System;
using TesteAlura.Cadastros;
using TesteAlura.Menus;
using TesteAlura.Models.Musica;
using TesteAlura.Seeds;


public class Program
{
    


    public static void Main()
    {
        
        CadastroArtistas artistas = new CadastroArtistas();
        DadosIniciais.Carregar(artistas);
        MenuArtistas menu = new MenuArtistas(artistas);
        menu.Exibir();



    }

    

    
}
