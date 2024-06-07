using gestor.Aplicacion.Entidades;

namespace gestor.Aplicacion.Interfaces;

public interface IImagenRepositorio
{
    void AltaImagen(Imagen imagen, Usuario usuario);
    void BajaImagen(int id);
    void ModificarImagen(Imagen imagen, int id);
    Imagen ConsultaId(int id);
    List<Imagen> ConsultaPorUsuario(int id);
}