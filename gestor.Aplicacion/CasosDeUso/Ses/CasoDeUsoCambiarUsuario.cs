using gestor.Aplicacion.Entidades;
using gestor.Aplicacion.Interfaces;

namespace gestor.Aplicacion.CasosDeUso.Ses;

public class CasoDeUsoCambiarUsuario(ISesion sesion)
{
    public void Cambiar(Usuario nuevoUsuario)
    {
        sesion.AlternarSesion();
        sesion.CambiarUsuario(nuevoUsuario);
    }
}