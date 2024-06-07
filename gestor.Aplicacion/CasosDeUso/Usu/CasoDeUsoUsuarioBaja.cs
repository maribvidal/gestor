using gestor.Aplicacion.Entidades;
using gestor.Aplicacion.Excepciones;
using gestor.Aplicacion.Interfaces;

namespace gestor.Aplicacion.CasosDeUso.Usu;

public class CasoDeUsoUsuarioBaja(IUsuarioRepositorio UsuRepo)
{
    public void Ejecutar(int id)
    {
        //Primero, comprobar que todo sea válido

        UsuRepo.BajaUsuario(id);
    }
}