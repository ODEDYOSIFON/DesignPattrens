namespace DesignPattrens.Structural.Composite
{
    // Leaf:
    // - Represents individual objects in the composition.
    // - Implements behavior defined in the Component.
    public class File : FileSystemItem
    {
        public File(string name) : base(name) { }

        // Prints the file's name with indentation.
        public override void Print(string indentation)
        {
            Console.WriteLine($"{indentation}File: {Name}");
        }
    }
}
