namespace Composite
{
    public class Directory : FileSystemElement
    {
        private List<FileSystemElement> elements = new List<FileSystemElement>();

        public Directory(string name) : base(name)
        {
        }

        public void Add(FileSystemElement element)
        {
            elements.Add(element);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);

            foreach (var element in elements)
            {
                element.Display(depth + 2);
            }
        }
    }
}