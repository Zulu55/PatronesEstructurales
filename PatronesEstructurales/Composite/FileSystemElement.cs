namespace Composite
{
    public abstract class FileSystemElement
    {
        public string Name { get; set; }

        public FileSystemElement(string name)
        {
            Name = name;
        }

        public abstract void Display(int depth);
    }
}