using gestor.Aplicacion.Entidades;
using gestor.Aplicacion.Excepciones;
using gestor.Aplicacion.Interfaces;

namespace gestor.Aplicacion.CasosDeUso.Usu;

public class CasoDeUsoUsuarioTienePermiso(IUsuarioRepositorio UsuRepo)
{
    public bool Ejecutar(int id, int idPermiso)
    {
        //Primero, comprobar que todo sea válido

        return UsuRepo.TienePermiso(id, idPermiso);
    }
}