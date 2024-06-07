using gestor.Aplicacion.Entidades;
using gestor.Aplicacion.Excepciones;
using gestor.Aplicacion.Interfaces;

namespace gestor.Aplicacion.CasosDeUso.Ima;

public class CasoDeUsoImagenConsultaId(IImagenRepositorio ImaRepo)
{
    public Imagen Ejecutar(int idImagen)
    {
        return ImaRepo.ConsultaId(idImagen);
    }
}