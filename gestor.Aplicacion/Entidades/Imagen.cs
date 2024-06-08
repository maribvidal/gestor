using gestor.Aplicacion.Enumerativos;

namespace gestor.Aplicacion.Entidades;

public class Imagen
{
    public int Id { get; set; }
    public string URL { get; set; } = "";
    public TipoImagen Tipo { get; set; }
    public int UsuarioId { get; set; }
}