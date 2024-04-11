namespace Facade
{
    public class ReproductorDvd
    {
        public void Encender() => Console.WriteLine("Reproductor DVD encendido.");

        public void Reproducir(string pelicula) => Console.WriteLine($"Reproduciendo {pelicula}.");
    }
}