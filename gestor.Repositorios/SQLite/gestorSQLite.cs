namespace gestor.Repositorios.SQLite;

public class gestorSQLite
{
    public static void Inicializar()
    {
        using var context = new gestorContext();
        if (context.Database.EnsureCreated())
        {
            Console.WriteLine(" * gestor.sqlite ha sido creado exitosamente");
        }
    }
}