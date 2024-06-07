using gestor.Aplicacion.Entidades;
using Microsoft.EntityFrameworkCore;

namespace gestor.Repositorios.SQLite;

public class gestorContext : DbContext
{
    #nullable disable
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Imagen> Imagenes { get; set; }
    #nullable enable

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("data source=gestor.sqlite");
    }
}