namespace DesignPattrens.Creational.Memento
{
    // Memento:
    // - Stores the internal state of the Originator (Editor).
    // - Is immutable: once created, its state cannot be changed.
    // - Provides a snapshot of the state without exposing implementation details.
    public class EditorMemento
    {
        public string Content { get; }

        public EditorMemento(string content)
        {
            Content = content;
        }
    }
}
