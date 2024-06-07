using gestor.Aplicacion.Entidades;
using gestor.Aplicacion.Excepciones;
using gestor.Aplicacion.Interfaces;
using gestor.Repositorios.SQLite;

namespace gestor.Repositorios;

public class UsuarioRepositorio : IUsuarioRepositorio
{
    //Esto es temporal hasta que sepa donde ubicarlo
    public UsuarioRepositorio() => gestorSQLite.Inicializar();

    //Operaciones
    public void AltaUsuario(Usuario usuario)
    {
        
    }

    public void BajaUsuario(int idUsuario)
    {

    }

    public void ModificarUsuario(Usuario nuevoUsuario, int idUsuario)
    {

    }

    public Usuario ConsultaId(int idUsuario)
    {
        using var db = new gestorContext(); //El contexto se va a cerrar cuando no hayan mas instrucciones
        var consultaUsuario = db.Usuarios.Where(user => user.Id == idUsuario).SingleOrDefault();

        //Comprobar que el usuario exista
        if (consultaUsuario == null)
            throw new RepositorioException($"El usuario con id {idUsuario} no se encuentra registrado");

        return consultaUsuario;
    }

    public List<Usuario> ConsultaTodos()
    {
        using var db = new gestorContext();

        var consultarTodos = db.Usuarios.ToList();

        //Como es una lista, no pasa nada al devolverla vacía
        return consultarTodos;
    }
}