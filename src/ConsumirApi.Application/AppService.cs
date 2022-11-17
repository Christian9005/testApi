

using System.Text.Json;
using ConsumirApi.Application.Interface;

namespace ConsumirApi.Application;

public class AppService : IAppService
{
    public Task<ICollection<Personajes>> GetAllAsync()
    {
        throw new NotImplementedException();
         // var url = "https://rickandmortyapi.com/api/character";
        // using (var httpClient = new HttpClient())
        // {
        //     var response = await httpClient.GetAsync(url);
        //     if (response.IsSuccessStatusCode)
        //     {
        //         var content = await response.Content.ReadAsStringAsync();
        //         var personajes = JsonSerializer.Deserialize<List<Personajes>>(content);
        //         foreach (var personaje in personajes)
        //         {
        //             Console.WriteLine($"Nombre: {personaje.Name}  Id: {personaje.Id}");
        //         }

        //     }

        // }
    }
}
