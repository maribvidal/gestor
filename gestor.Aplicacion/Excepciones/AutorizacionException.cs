namespace gestor.Aplicacion.Excepciones
{
    public class AutorizacionException : InvalidOperationException
    {
        public AutorizacionException(string razon) : base(razon) { }
    }
}