using gestor.Aplicacion.Entidades;
using gestor.Aplicacion.Interfaces;

namespace gestor.Aplicacion.Servicios;

//Esta clase vendría a representar una sesión de navegador
public class Sesion : ISesion
{
    private bool _sesionAutorizada = false;
    private Usuario? _sesionUsuario;

    public void AgregarUsuario(Usuario usuario)
    {
        _sesionUsuario = usuario;
        _sesionAutorizada = true;
    }

    public bool estaAutorizada() => _sesionAutorizada;
    public Usuario ObtenerUsuario() => _sesionUsuario ?? new Usuario();

    //Métodos de prueba
    public void AlternarSesion() => _sesionAutorizada = !_sesionAutorizada;
    public void CambiarUsuario(Usuario usuario) => _sesionUsuario = usuario;
}