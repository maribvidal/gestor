using gestor.Aplicacion.Entidades;

namespace gestor.Aplicacion.Interfaces;

public interface IImagenRepositorio
{
    void AltaImagen(Imagen imagen);
    void BajaImagen(int id);
    void ModificarImagen(Imagen imagen, int id);
    Imagen ConsultaPorId(int id);
    List<Imagen> ConsultaPorUsuario(int id);
}