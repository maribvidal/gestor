using gestor.Aplicacion.Entidades;
using gestor.Aplicacion.Interfaces;
using static System.Uri;

namespace gestor.Aplicacion.Validadores;

public class ImagenValidador : IImagenValidador
{
    public bool Validar(string imagenURL)
    {
        return (imagenURL != "" && EsUnaURL(imagenURL));
    }

    // Este método retorna true si el enlace pasado está "bien formado"
    private bool EsUnaURL(string imagenURL)
    {
        return (Uri.IsWellFormedUriString(imagenURL, UriKind.Absolute));
    }
}