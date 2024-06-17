using gestor.UI.Components;

//Nuevas directivas agregadas (para poder manejar los repositorios)
using gestor.Repositorios;
using gestor.Repositorios.SQLite;

using gestor.Aplicacion.CasosDeUso.Usu;
using gestor.Aplicacion.CasosDeUso.Ima;
using gestor.Aplicacion.CasosDeUso.Ses;
using gestor.Aplicacion.CasosDeUso.Has;

using gestor.Aplicacion.Interfaces;
using gestor.Aplicacion.Entidades;
using gestor.Aplicacion.Enumerativos;
using gestor.Aplicacion.Validadores;
using gestor.Aplicacion.Servicios;

var builder = WebApplication.CreateBuilder(args);

//Agregar serivicos al Contenedor de Inyecciones (Dl Container)
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

//  - Los nuestros
gestorContext contexto = new gestorContext(); //Vamos a compartir el
builder.Services.AddSingleton<IHasher, Hasher>();
builder.Services.AddTransient<CasoDeUsoObtenerHash>();

//  Sesión de usuario
builder.Services.AddScoped<CasoDeUsoSesionEstado>();
builder.Services.AddScoped<CasoDeUsoAlternarSesion>();
builder.Services.AddScoped<CasoDeUsoObtenerUsuario>();
builder.Services.AddScoped<CasoDeUsoCambiarUsuario>();
builder.Services.AddScoped<ISesion, Sesion>();

// Validadores
builder.Services.AddSingleton<IImagenValidador, ImagenValidador>();
builder.Services.AddSingleton<IUsuarioValidador, UsuarioValidador>();

// Casos de uso - USUARIO
builder.Services.AddTransient<CasoDeUsoUsuarioAlta>();
builder.Services.AddTransient<CasoDeUsoUsuarioModificar>();
builder.Services.AddTransient<CasoDeUsoUsuarioConsultaPorId>();
builder.Services.AddTransient<CasoDeUsoUsuarioConsultaTodos>();
builder.Services.AddTransient<CasoDeUsoUsuarioConsultaPermisos>();
builder.Services.AddTransient<CasoDeUsoUsuarioTienePermiso>();

// Casos de uso - IMAGEN
builder.Services.AddTransient<CasoDeUsoImagenAlta>();
builder.Services.AddTransient<CasoDeUsoImagenConsultaPorUsuario>();

// Repositorios
builder.Services.AddSingleton<IUsuarioRepositorio, UsuarioRepositorio>(usuRepo => new UsuarioRepositorio(contexto));
builder.Services.AddSingleton<IImagenRepositorio, ImagenRepositorio>(imaRepo => new ImagenRepositorio(contexto));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();