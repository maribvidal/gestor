using gestor.Aplicacion.Entidades;
using gestor.Aplicacion.Interfaces;

namespace gestor.Aplicacion.CasosDeUso.Ses;
public class CasoDeUsoAlternarSesion(ISesion sesion)
{
    public void Cambiar()
    {
        sesion.AlternarSesion();
    }
}