using gestor.Aplicacion.Interfaces;
using gestor.Aplicacion.Servicios;

namespace gestor.Aplicacion.CasosDeUso.Has;

public class CasoDeUsoObtenerHash(IHasher Hasher)
{
    public string Obtener(string contraseña)
    {
        return Hasher.ObtenerHash(contraseña);
    }
}