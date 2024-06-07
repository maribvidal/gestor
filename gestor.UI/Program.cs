using gestor.UI.Components;

//Nuevas directivas agregadas (para poder manejar los repositorios)
using gestor.Repositorios;
using gestor.Aplicacion.CasosDeUso.Usu;
using gestor.Aplicacion.Interfaces;
using gestor.Aplicacion.Entidades;

var builder = WebApplication.CreateBuilder(args);

//Agregar serivicos al Contenedor de Inyecciones (Dl Container)
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

//  - Los nuestros
builder.Services.AddTransient<CasoDeUsoUsuarioConsultaTodos>();
builder.Services.AddSingleton<IUsuarioRepositorio, UsuarioRepositorio>();

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