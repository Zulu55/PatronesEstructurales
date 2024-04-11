using Facade;

internal class Program
{
    private static void Main(string[] args)
    {
        var proyector = new Proyector();
        var reproductorDvd = new ReproductorDvd();
        var sistemaSonido = new SistemaSonido();

        var homeTheater = new HomeTheaterFacade(proyector, reproductorDvd, sistemaSonido);

        homeTheater.VerPelicula("El Señor de los Anillos");
        homeTheater.ApagarTodo();
    }
}