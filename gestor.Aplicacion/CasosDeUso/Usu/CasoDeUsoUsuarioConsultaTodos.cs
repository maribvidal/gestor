using gestor.Aplicacion.Entidades;
using gestor.Aplicacion.Excepciones;
using gestor.Aplicacion.Interfaces;

namespace gestor.Aplicacion.CasosDeUso.Usu;

public class CasoDeUsoUsuarioConsultaTodos(IUsuarioRepositorio UsuRepo)
{
    public List<Usuario> Ejecutar()
    {
        //Primero, comprobar que todo sea válido

        return UsuRepo.ConsultaTodos();
    }
}