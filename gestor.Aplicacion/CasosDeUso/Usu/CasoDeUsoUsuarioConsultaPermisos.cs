using gestor.Aplicacion.Entidades;
using gestor.Aplicacion.Excepciones;
using gestor.Aplicacion.Interfaces;

namespace gestor.Aplicacion.CasosDeUso.Usu;

public class CasoDeUsoUsuarioConsultaPermisos(IUsuarioRepositorio UsuRepo)
{
    public List<Permiso> Ejecutar(int id)
    {
        //Primero, comprobar que todo sea válido

        return UsuRepo.ConsultaPermisos(id);
    }
}