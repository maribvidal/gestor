using gestor.Aplicacion.Entidades;
using gestor.Aplicacion.Excepciones;
using gestor.Aplicacion.Interfaces;

namespace gestor.Aplicacion.CasosDeUso.Ima;

public class CasoDeUsoImagenConsultaPorId(IImagenRepositorio ImaRepo, IUsuarioValidador UsuVali)
{
    public Imagen Ejecutar(int idImagen, Usuario usuario)
    {
        //Verificar si el usuario existe

        if (!UsuVali.Validar(usuario, 1))
            throw new ValidacionException($"El usuario {usuario.Id} no tiene el permiso requerido (lectura)");

        return ImaRepo.ConsultaPorId(idImagen);
    }
}