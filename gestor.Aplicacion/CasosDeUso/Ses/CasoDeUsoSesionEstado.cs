using gestor.Aplicacion.Entidades;
using gestor.Aplicacion.Interfaces;

namespace gestor.Aplicacion.CasosDeUso.Ses;
public class CasoDeUsoSesionEstado(ISesion sesion)
{
    public bool Obtener()
    {
        return sesion.estaAutorizada();
    }
}