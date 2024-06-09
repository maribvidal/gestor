using gestor.Aplicacion.Entidades;
using gestor.Aplicacion.Excepciones;
using gestor.Aplicacion.Interfaces;

namespace gestor.Aplicacion.CasosDeUso.Ima;

public class CasoDeUsoImagenModificar(IImagenRepositorio ImaRepo, IImagenValidador ImaVali, IUsuarioValidador UsuVali)
{
    public void Ejecutar(Imagen nuevaImagen, int idImagen, Usuario usuario)
    {
        //Verificar si el usuario existe

        if (!UsuVali.Validar(usuario, 2))
            throw new ValidacionException($"El usuario {usuario.Id} no tiene el permiso requerido (escritura)");
        
        if (!ImaVali.Validar(nuevaImagen.URL))
            throw new ValidacionException("La URL de la nueva imagen no es válida");

        ImaRepo.ModificarImagen(nuevaImagen, idImagen);
    }
}