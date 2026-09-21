using TesteAlura.Cadastros;
using TesteAlura.Models.Musica;

namespace TesteAlura.Seeds
{
    internal static class DadosIniciais
    {
        // Chame uma vez por cadastro. Cada chamada adiciona novos registros.
        // Slipknot e Linkin Park: formações históricas de Iowa e Meteora.
        // Seleção parcial de músicas, com durações aproximadas em segundos.
        // Disponibilidade é fictícia. AnoInicio dos gêneros não foi preenchido.
        public static void Carregar(CadastroArtistas cadastro)
        {
            Genero metal = new Genero { Nome = "Metal alternativo" };
            Genero industrial = new Genero { Nome = "Rock industrial" };

            Banda slipknot = cadastro.CadastrarBanda("Slipknot");
            slipknot.AdicionarIntegrante("Corey Taylor");
            slipknot.AdicionarIntegrante("Mick Thomson");
            slipknot.AdicionarIntegrante("Jim Root");
            slipknot.AdicionarIntegrante("Paul Gray");
            slipknot.AdicionarIntegrante("Joey Jordison");
            slipknot.AdicionarIntegrante("Shawn Crahan");
            slipknot.AdicionarIntegrante("Chris Fehn");
            slipknot.AdicionarIntegrante("Sid Wilson");
            slipknot.AdicionarIntegrante("Craig Jones");
            Album slipknotAlbum = new Album("Iowa");
            slipknotAlbum.AnoLancamento = 2001;

            Musica slipknotMusica1 = new Musica(slipknot, "Left Behind");
            slipknotMusica1.Duracao = 241;
            slipknotMusica1.Disponivel = true;
            slipknotMusica1.AlterarGeneroMusica(metal);
            slipknotAlbum.AdicionarMusica(slipknotMusica1);

            Musica slipknotMusica2 = new Musica(slipknot, "People = Shit");
            slipknotMusica2.Duracao = 215;
            slipknotMusica2.Disponivel = false;
            slipknotMusica2.AlterarGeneroMusica(metal);
            slipknotAlbum.AdicionarMusica(slipknotMusica2);
            slipknot.AdicionarAlbum(slipknotAlbum);

            Banda linkinPark = cadastro.CadastrarBanda("Linkin Park");
            linkinPark.AdicionarIntegrante("Chester Bennington");
            linkinPark.AdicionarIntegrante("Mike Shinoda");
            linkinPark.AdicionarIntegrante("Brad Delson");
            linkinPark.AdicionarIntegrante("Dave Farrell");
            linkinPark.AdicionarIntegrante("Joe Hahn");
            linkinPark.AdicionarIntegrante("Rob Bourdon");
            Album linkinParkAlbum = new Album("Meteora");
            linkinParkAlbum.AnoLancamento = 2003;

            Musica linkinParkMusica1 = new Musica(linkinPark, "Numb");
            linkinParkMusica1.Duracao = 187;
            linkinParkMusica1.Disponivel = true;
            linkinParkMusica1.AlterarGeneroMusica(metal);
            linkinParkAlbum.AdicionarMusica(linkinParkMusica1);

            Musica linkinParkMusica2 = new Musica(linkinPark, "Somewhere I Belong");
            linkinParkMusica2.Duracao = 213;
            linkinParkMusica2.Disponivel = false;
            linkinParkMusica2.AlterarGeneroMusica(metal);
            linkinParkAlbum.AdicionarMusica(linkinParkMusica2);
            linkinPark.AdicionarAlbum(linkinParkAlbum);

            Banda system = cadastro.CadastrarBanda("System of a Down");
            system.AdicionarIntegrante("Serj Tankian");
            system.AdicionarIntegrante("Daron Malakian");
            system.AdicionarIntegrante("Shavo Odadjian");
            system.AdicionarIntegrante("John Dolmayan");
            Album systemAlbum = new Album("Toxicity");
            systemAlbum.AnoLancamento = 2001;

            Musica systemMusica1 = new Musica(system, "Chop Suey!");
            systemMusica1.Duracao = 210;
            systemMusica1.Disponivel = true;
            systemMusica1.AlterarGeneroMusica(metal);
            systemAlbum.AdicionarMusica(systemMusica1);

            Musica systemMusica2 = new Musica(system, "Toxicity");
            systemMusica2.Duracao = 218;
            systemMusica2.Disponivel = false;
            systemMusica2.AlterarGeneroMusica(metal);
            systemAlbum.AdicionarMusica(systemMusica2);
            system.AdicionarAlbum(systemAlbum);

            Artista manson = cadastro.CadastrarArtistaSolo("Marilyn Manson");
            Album mansonAlbum = new Album("The Pale Emperor");
            mansonAlbum.AnoLancamento = 2015;

            Musica mansonMusica1 = new Musica(manson, "Third Day of a Seven Day Binge");
            mansonMusica1.Duracao = 266;
            mansonMusica1.Disponivel = true;
            mansonMusica1.AlterarGeneroMusica(industrial);
            mansonAlbum.AdicionarMusica(mansonMusica1);

            Musica mansonMusica2 = new Musica(manson, "Deep Six");
            mansonMusica2.Duracao = 302;
            mansonMusica2.Disponivel = false;
            mansonMusica2.AlterarGeneroMusica(industrial);
            mansonAlbum.AdicionarMusica(mansonMusica2);
            manson.AdicionarAlbum(mansonAlbum);
        }
    }
}