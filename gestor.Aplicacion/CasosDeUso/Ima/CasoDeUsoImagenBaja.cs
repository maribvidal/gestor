using gestor.Aplicacion.Entidades;
using gestor.Aplicacion.Excepciones;
using gestor.Aplicacion.Interfaces;

namespace gestor.Aplicacion.CasosDeUso.Ima;

public class CasoDeUsoImagenBaja(IImagenRepositorio ImaRepo)
{
    public void Ejecutar(int idImagen, Usuario usuario)
    {
        //Primero, comprobar que todo sea válido
        //TO-DO: Revisar permisos del usuario
        
        ImaRepo.BajaImagen(idImagen);
    }
}