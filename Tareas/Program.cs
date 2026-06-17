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

static void mostrarTareas(List<Tareas> tareas)
{
    foreach (var item in tareas)
    {
        System.Console.WriteLine(item.mostrarTareas());
    }
}

mostrarTareas(objResponse);
