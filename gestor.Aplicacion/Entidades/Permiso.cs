namespace gestor.Aplicacion.Entidades;

public class Permiso
{
    public int Id { get; set; }
    public string? Tipo { get; set; }
    public List<Usuario>? Usuarios { get; set; }
}