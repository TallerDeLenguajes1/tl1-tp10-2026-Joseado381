using System.Text.Json;

string urlBase = "https://jsonplaceholder.typicode.com/todos";

var client = new HttpClient();

var response = await client.GetAsync(urlBase);
var strResponse = await response.Content.ReadAsStringAsync();

List<Tareas> objResponse = JsonSerializer.Deserialize<List<Tareas>>(strResponse);

string contenido = "";

foreach (var item in objResponse)
{
    System.Console.WriteLine($"UserID: {item.UserID} - ID: {item.Id} - Título: {item.Title} - Completada: {item.Completed}\n");    
}

string path = @"C:\Users\jose\Escritorio\cosas facet\Taller de Lenguaje1\2026\tl1-tp10-2026-Joseado381\Tareas\";
