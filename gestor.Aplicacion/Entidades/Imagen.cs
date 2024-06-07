using gestor.Aplicacion.Enumerativos;

namespace gestor.Aplicacion.Entidades;

public class Imagen
{
    public int Id { get; set; }
    public string URL { get; private set; } = "";
    public TipoImagen Tipo { get; set; }
    //El campo UsuarioId lo implementa automáticamente SQLite
}