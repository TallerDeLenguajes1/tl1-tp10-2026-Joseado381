public class Tareas
{
    public int UserID { get; set; }
    public int Id { get; set; }
    public string Title { get; set; }
    public bool Completed { get; set; }

    public string mostrarTareas()
    {
        return $"UserID: {UserID} - ID: {Id} - Título: {Title} - Completada: {Completed}\n";
    }
}