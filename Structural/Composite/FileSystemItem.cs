namespace DesignPattrens.Structural.Composite
{
    // Component:
    // - Declares the common interface for both leaves (File) and composites (Directory).
    // - Defines operations that can be performed uniformly.
    public abstract class FileSystemItem
    {
        protected string Name;

        protected FileSystemItem(string name)
        {
            Name = name;
        }

        // Print method will be implemented by both File and Directory.
        public abstract void Print(string indentation = "");
    }
}
