using gestor.Aplicacion.Enumerativos;

namespace gestor.Aplicacion.Entidades;

public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; } = "";
    public string Contraseña { get; set; } = "";
    public DateTime FechaCreacion { get; set; }

    public List<Imagen>? Imagenes { get; set; } = new List<Imagen>(); //Propiedad de navegación
    public List<Permiso>? Permisos { get; set; } = new List<Permiso>();
}