using SGE.Aplicacion.Enumerativos;

namespace gestor.Aplicacion.Entidades;

public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; } = "";
    public string Contraseña { get; private set; } = "";
    public DateTime FechaCreacion { get; set; }
    public TipoCuenta Tipo { get; set; }

    public List<Imagen>? Imagenes { get; set; } //Propiedad de navegación
}