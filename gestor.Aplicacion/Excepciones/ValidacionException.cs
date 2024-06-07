namespace gestor.Aplicacion.Excepciones
{
    public class ValidacionException : InvalidOperationException
    {
        public ValidacionException(string razon) : base(razon) { }
    }
}