using gestor.Repositorios.SQLite;

namespace gestor.Repositorios;

public abstract class Repositorio
{
    protected readonly gestorContext Contexto; //   - GRACIAS FABRO

    protected Repositorio(gestorContext contexto)
    {
        Contexto = contexto; // Pasarle el contexto 
        gestorSQLite.Inicializar(); //  Ya que estamos, asegurarnos de que existe la base de datos
    }
}