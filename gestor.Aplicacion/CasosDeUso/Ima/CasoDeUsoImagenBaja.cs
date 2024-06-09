using gestor.Aplicacion.Entidades;
using gestor.Aplicacion.Excepciones;
using gestor.Aplicacion.Interfaces;

namespace gestor.Aplicacion.CasosDeUso.Ima;

public class CasoDeUsoImagenBaja(IImagenRepositorio ImaRepo, IUsuarioValidador UsuVali)
{
    public void Ejecutar(int idImagen, Usuario usuario)
    {
        if (!UsuVali.Validar(usuario, 2))
            throw new ValidacionException($"El usuario {usuario.Id} no tiene el permiso requerido");
        
        ImaRepo.BajaImagen(idImagen);
    }
}