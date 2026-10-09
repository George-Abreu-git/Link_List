using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TesteAlura.Models.Musica;




namespace Link_List.Services
{
    internal class CatalogoMusicalService
    {
        HttpClient client = new HttpClient();
        


        public async Task<string> ExibirCatalogo(string endpoint)
        {
            string resposta;
            try 
            {
                return resposta = await client.GetStringAsync(endpoint);

                var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);
                Console.WriteLine(musicas.Count);


            }
            catch (Exception ex)
            {
                return resposta = $"Temos um erro inesperado: {ex.Message}";
            }
            
        }
    }
}


