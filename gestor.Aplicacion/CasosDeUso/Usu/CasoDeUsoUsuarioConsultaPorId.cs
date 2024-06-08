using gestor.Aplicacion.Entidades;
using gestor.Aplicacion.Excepciones;
using gestor.Aplicacion.Interfaces;

namespace gestor.Aplicacion.CasosDeUso.Usu;

public class CasoDeUsoUsuarioConsultaPorId(IUsuarioRepositorio UsuRepo)
{
    public Usuario Ejecutar(int id)
    {
        //Primero, comprobar que todo sea válido

        return UsuRepo.ConsultaPorId(id);
    }
}