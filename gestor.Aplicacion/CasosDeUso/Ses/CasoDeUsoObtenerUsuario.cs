using gestor.Aplicacion.Entidades;
using gestor.Aplicacion.Interfaces;

namespace gestor.Aplicacion.CasosDeUso.Ses;

public class CasoDeUsoObtenerUsuario(ISesion sesion)
{
    public Usuario? Obtener()
    {
        return sesion.ObtenerUsuario();
    }
}