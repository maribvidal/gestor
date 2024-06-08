using gestor.Aplicacion.Entidades;

namespace gestor.Aplicacion.Interfaces;

public interface IUsuarioValidador
{
    bool Validar(Usuario usuario, int id);
}