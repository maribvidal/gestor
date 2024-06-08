using gestor.Aplicacion.Entidades;
using gestor.Aplicacion.Excepciones;
using gestor.Aplicacion.Interfaces;
using gestor.Repositorios.SQLite;
using Microsoft.EntityFrameworkCore;

namespace gestor.Repositorios;

public class UsuarioRepositorio : Repositorio, IUsuarioRepositorio
{
    //Llamar al constructor de la clase base con un contexto
    public UsuarioRepositorio(gestorContext Contexto) : base(Contexto) {}

    //Operaciones
    public void AltaUsuario(Usuario usuario)
    {
        usuario.FechaCreacion = DateTime.Now; //Poner la fecha del momento
        Contexto.Usuarios.Add(usuario);
        Contexto.SaveChanges();
    }

    public void BajaUsuario(int id)
    {
        var usuarioConsultado = Contexto.Usuarios.Where(user => user.Id == id).SingleOrDefault();

        if (usuarioConsultado == null)
            throw new RepositorioException($"El usuario con id {id} no se encuentra registrado");
        
        Contexto.Remove(usuarioConsultado);
        Contexto.SaveChanges();
    }

    public void ModificarUsuario(Usuario usuario, int id)
    {
        var usuarioConsultado = Contexto.Usuarios.Where(user => user.Id == id).SingleOrDefault();

        if (usuarioConsultado == null)
            throw new RepositorioException($"El usuario con id {id} no se encuentra registrado");
        
        //"Sobreescribir" usuario
        usuarioConsultado = usuario;
        Contexto.SaveChanges();
    }

    public Usuario ConsultaPorId(int id)
    {
        var consultaUsuario = Contexto.Usuarios.Where(user => user.Id == id).Include(u => u.Permisos).SingleOrDefault();

        //Comprobar que el usuario exista
        if (consultaUsuario == null)
            throw new RepositorioException($"El usuario con id {id} no se encuentra registrado");

        return consultaUsuario;
    }

    public List<Usuario> ConsultaTodos()
    {
        List<Usuario> consultarTodos = Contexto.Usuarios.Include(u => u.Permisos).ToList() ?? new List<Usuario>();

        //Como es una lista, no pasa nada al devolverla vacía
        return consultarTodos;
    }

    public List<Permiso> ConsultaPermisos(int id)
    {
        var consultaUsuario = Contexto.Usuarios.Where(u => u.Id == id).SingleOrDefault() ?? throw new RepositorioException($"El usuario con id {id} no se encuentra registrado");
        var consultaPermisos = consultaUsuario?.Permisos?.ToList();
        return consultaPermisos ?? new List<Permiso>();
    }
}