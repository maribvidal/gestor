using gestor.Aplicacion.Entidades;
using gestor.Aplicacion.Interfaces;

namespace gestor.Aplicacion.Validadores;

public class UsuarioValidador : IUsuarioValidador
{
    //Este método se fija si existe el permiso pasado dentro de la lista del usuario
    public bool Validar(Usuario usuario, int permisoId) => (usuario?.Permisos?.FindIndex(per => per.Id == permisoId) != -1);
}