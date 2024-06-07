using gestor.Aplicacion.Entidades;
using gestor.Aplicacion.Excepciones;
using gestor.Aplicacion.Interfaces;

namespace gestor.Aplicacion.CasosDeUso.Ima;

public class CasoDeUsoImagenConsultaPorUsuario(IImagenRepositorio ImaRepo)
{
    public List<Imagen> Ejecutar(int idUsuario)
    {
        //Primero, verificar si el usuario existe

        return ImaRepo.ConsultaPorUsuario(idUsuario);
    }
}