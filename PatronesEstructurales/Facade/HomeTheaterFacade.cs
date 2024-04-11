namespace Facade
{
    public class HomeTheaterFacade
    {
        private Proyector _proyector;
        private ReproductorDvd _reproductorDvd;
        private SistemaSonido _sistemaSonido;

        public HomeTheaterFacade(Proyector proyector, ReproductorDvd reproductorDvd, SistemaSonido sistemaSonido)
        {
            _proyector = proyector;
            _reproductorDvd = reproductorDvd;
            _sistemaSonido = sistemaSonido;
        }

        public void VerPelicula(string pelicula)
        {
            Console.WriteLine("Preparándose para ver una película...");
            _proyector.Encender();
            _proyector.ConfigurarModo("cine");
            _reproductorDvd.Encender();
            _sistemaSonido.Encender();
            _sistemaSonido.ConfigurarVolumen(10);
            _reproductorDvd.Reproducir(pelicula);
        }

        public void ApagarTodo()
        {
            Console.WriteLine("Apagando el sistema de Home Theater...");
            // Aquí irían las llamadas para apagar cada componente
        }
    }
}