using gestor.Aplicacion.Entidades;
using gestor.Aplicacion.Excepciones;
using gestor.Aplicacion.Interfaces;

namespace gestor.Aplicacion.CasosDeUso.Usu;

public class CasoDeUsoUsuarioAlta(IUsuarioRepositorio UsuRepo)
{
    public void Ejecutar(Usuario usuario)
    {
        //Primero, comprobar que todo sea válido

        UsuRepo.AltaUsuario(usuario);
    }
}