using gestor.Aplicacion.Entidades;
using gestor.Aplicacion.Excepciones;
using gestor.Aplicacion.Interfaces;
using gestor.Repositorios.SQLite;

namespace gestor.Repositorios;

public class ImagenRepositorio : Repositorio, IImagenRepositorio
{
    public ImagenRepositorio(gestorContext Contexto) : base(Contexto) {}

    public void AltaImagen(Imagen imagen) 
    {
        Contexto.Imagenes.Add(imagen);
    }
    public void BajaImagen(int id) 
    {
        Imagen imagenConsultada = Contexto.Imagenes.Where(img => img.Id == id).SingleOrDefault() ?? throw new RepositorioException($"La imagen con id {id} no se encuentra registrada");
        Contexto.Remove(imagenConsultada);
    }
    public void ModificarImagen(Imagen imagen, int id) 
    {
        Imagen imagenConsultada = Contexto.Imagenes.Where(img => img.Id == id).SingleOrDefault() ?? throw new RepositorioException($"La imagen con id {id} no se encuentra registrada");
        imagenConsultada = imagen;

    }
    public Imagen ConsultaPorId(int id) 
    {
        Imagen imagenConsultada = Contexto.Imagenes.Where(img => img.Id == id).SingleOrDefault() ?? throw new RepositorioException($"La imagen con id {id} no se encuentra registrada");
        return imagenConsultada;
    }
    public List<Imagen> ConsultaPorUsuario(int id) 
    {
        List<Imagen> listaConsultada = Contexto.Imagenes.Where(img => img.UsuarioId == id).ToList() ?? new List<Imagen>();
        return listaConsultada;
    }
}