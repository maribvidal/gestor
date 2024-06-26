using gestor.Aplicacion.Entidades;

namespace gestor.Aplicacion.Interfaces;

public interface IUsuarioRepositorio
{
    void AltaUsuario(Usuario usuario);
    void BajaUsuario(int id);
    void ModificarUsuario(Usuario usuario, int id);
    Usuario ConsultaPorId(int id);
    List<Usuario> ConsultaTodos();
    List<Permiso> ConsultaPermisos(int id);
    bool TienePermiso(int id, int idPermiso);
}