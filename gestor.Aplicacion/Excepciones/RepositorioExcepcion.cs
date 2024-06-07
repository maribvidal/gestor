namespace gestor.Aplicacion.Excepciones
{
    public class RepositorioException : InvalidOperationException
    {
        public RepositorioException(string razon) : base(razon) { }
    }
}