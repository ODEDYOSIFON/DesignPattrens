namespace DesignPattrens.Structural.Composite
{
    // Composite:
    // - Represents nodes that can have children (both Files and Directories).
    // - Implements child management (Add).
    public class Directory : FileSystemItem
    {
        private List<FileSystemItem> _items = new List<FileSystemItem>();

        public Directory(string name) : base(name) { }

        // Add child items (Files or Directories).
        public void Add(FileSystemItem item)
        {
            _items.Add(item);
        }

        // Prints directory and recursively prints children with indentation.
        public override void Print(string indentation = "")
        {
            Console.WriteLine($"{indentation}Directory: {Name}");
            foreach (var item in _items)
            {
                item.Print(indentation + "  ");
            }
        }
    }
}
