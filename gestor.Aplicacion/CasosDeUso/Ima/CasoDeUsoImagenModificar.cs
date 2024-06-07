using gestor.Aplicacion.Entidades;
using gestor.Aplicacion.Excepciones;
using gestor.Aplicacion.Interfaces;

namespace gestor.Aplicacion.CasosDeUso.Ima;

public class CasoDeUsoImagenModificar(IImagenRepositorio ImaRepo, IImagenValidador ImaVali)
{
    public void Ejecutar(Imagen nuevaImagen, int idImagen, Usuario usuario)
    {
        //Primero, comprobar que todo sea válido
        //TO-DO: Revisar permisos del usuario
        
        if (!ImaVali.Validar(nuevaImagen.URL))
            throw new ValidacionException("La URL de la nueva imagen no es válida");

        ImaRepo.ModificarImagen(nuevaImagen, idImagen);
    }
}