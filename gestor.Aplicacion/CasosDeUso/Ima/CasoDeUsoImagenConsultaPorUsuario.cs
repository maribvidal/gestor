using gestor.Aplicacion.Entidades;
using gestor.Aplicacion.Excepciones;
using gestor.Aplicacion.Interfaces;

namespace gestor.Aplicacion.CasosDeUso.Ima;

public class CasoDeUsoImagenConsultaPorUsuario(IImagenRepositorio ImaRepo, IUsuarioValidador UsuVali)
{
    public List<Imagen> Ejecutar(int idUsuario, Usuario usuario)
    {
        //Verificar si el usuario existe

        if (!UsuVali.Validar(usuario, 1))
            throw new ValidacionException($"El usuario {usuario.Id} no tiene el permiso requerido (lectura)");

        return ImaRepo.ConsultaPorUsuario(idUsuario);
    }
}