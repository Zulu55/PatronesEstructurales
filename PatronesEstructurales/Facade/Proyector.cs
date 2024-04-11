namespace Facade
{
    public class Proyector
    {
        public void Encender() => Console.WriteLine("Proyector encendido.");

        public void ConfigurarModo(string modo) => Console.WriteLine($"Proyector en modo {modo}.");
    }
}