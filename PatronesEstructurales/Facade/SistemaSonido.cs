namespace Facade
{
    public class SistemaSonido
    {
        public void Encender() => Console.WriteLine("Sistema de sonido encendido.");

        public void ConfigurarVolumen(int nivel) => Console.WriteLine($"Volumen ajustado a {nivel}.");
    }
}