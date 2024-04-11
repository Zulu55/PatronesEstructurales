internal class Program
{
    private static void Main(string[] args)
    {
        // Crear elementos del sistema de archivos
        var rootDirectory = new Composite.Directory("Root");
        var file1 = new Composite.File("Archivo1.txt");
        var file2 = new Composite.File("Archivo2.txt");
        var subDirectory = new Composite.Directory("Subdirectorio");

        // Construir la estructura del árbol
        rootDirectory.Add(file1);
        rootDirectory.Add(subDirectory);
        subDirectory.Add(file2);

        // Mostrar la estructura
        rootDirectory.Display(1);
    }
}