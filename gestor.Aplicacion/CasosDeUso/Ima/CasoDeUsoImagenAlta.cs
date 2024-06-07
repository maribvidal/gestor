using gestor.Aplicacion.Entidades;
using gestor.Aplicacion.Excepciones;
using gestor.Aplicacion.Interfaces;

namespace gestor.Aplicacion.CasosDeUso.Ima;

public class CasoDeUsoImagenAlta(IImagenRepositorio ImaRepo, IImagenValidador ImaVali)
{
    public void Ejecutar(Imagen imagen, Usuario usuario)
    {
        //Primero, comprobar que todo sea válido
        //TO-DO: Revisar permisos del usuario

        if (!ImaVali.Validar(imagen.URL))
            throw new ValidacionException("La URL no es válida");
        
        ImaRepo.AltaImagen(imagen, usuario);
    }
}