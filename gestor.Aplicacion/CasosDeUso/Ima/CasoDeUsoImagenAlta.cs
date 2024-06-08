using gestor.Aplicacion.Entidades;
using gestor.Aplicacion.Excepciones;
using gestor.Aplicacion.Interfaces;

namespace gestor.Aplicacion.CasosDeUso.Ima;

public class CasoDeUsoImagenAlta(IImagenRepositorio ImaRepo, IImagenValidador ImaVali, IUsuarioValidador UsuVali)
{
    public void Ejecutar(Imagen imagen, Usuario usuario)
    {
        if (!UsuVali.Validar(usuario, 2))
            throw new ValidacionException("El usuario no tiene el permiso requerido (escritura)");

        if (!ImaVali.Validar(imagen.URL))
            throw new ValidacionException("La URL no es válida");
        
        usuario?.Imagenes?.Add(imagen); //Vincularla con el usuario
        ImaRepo.AltaImagen(imagen);
    }
}