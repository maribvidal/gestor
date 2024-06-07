using gestor.Aplicacion.Entidades;
using gestor.Aplicacion.Excepciones;
using gestor.Aplicacion.Interfaces;

namespace gestor.Aplicacion.CasosDeUso.Usu;

public class CasoDeUsoUsuarioModificar(IUsuarioRepositorio UsuRepo)
{
    public void Ejecutar(Usuario usuario, int id)
    {
        //Primero, comprobar que todo sea válido

        UsuRepo.ModificarUsuario(usuario, id);
    }
}