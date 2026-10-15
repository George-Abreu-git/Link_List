using Link_List.Models;

namespace Link_List.Cadastros
{
   internal class CadastroArtistas
   {
       private List<ArtistaMusicalSolo> artistas = new List<ArtistaMusicalSolo>();
       private int proxId = 1;

       public ArtistaMusicalSolo CadastrarArtistaSolo(string nome)
       {
           ArtistaMusicalSolo artista = new ArtistaMusicalSolo(proxId, nome);
           artistas.Add(artista);
           proxId++;
           return artista;
       }

       public void ExcluirArtista(int id)
       {
           if (VerificarIdExistente(id, out ArtistaMusicalSolo artista))
           {
               artistas.Remove(artista);
           }
       }

       public void ListarAtrações()
       {
           foreach (ArtistaMusicalSolo registro in artistas)
           {
               Console.WriteLine($"{registro.Id} - {registro.Nome}\n");
           }
       }

       public bool VerificarIdExistente(int id, out ArtistaMusicalSolo artista)
       {
           foreach (ArtistaMusicalSolo artistaCadastrado in artistas)
           {
               if (artistaCadastrado.Id == id)
               {
                   artista = artistaCadastrado;
                   return true;
               }
           }


           
           artista = null;
           return false;
       }

       //public Banda CadastrarBanda(string nome)
       //{
       //    Banda banda = new Banda(proxId, nome);

       //    artistas.Add(banda);
       //    proxId++;
       //    return banda;
       //}
   }
}
