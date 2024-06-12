using gestor.Aplicacion.Entidades;

namespace gestor.Aplicacion.Interfaces;

public interface ISesion
{
    void AgregarUsuario(Usuario usuario);
    public bool estaAutorizada();
    public Usuario? ObtenerUsuario();
    public void AlternarSesion();
    public void CambiarUsuario(Usuario usuario);
}