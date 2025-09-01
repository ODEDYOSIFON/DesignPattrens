namespace DesignPattrens.Creational.Memento
{
    // Originator:
    // - The object whose state we want to save and restore later.
    // - Responsible for creating a Memento with its current state
    //   and restoring its state from a Memento.
    public class Editor
    {
        public string Content { get; set; }

        // Creates a new memento snapshot of the current state.
        public EditorMemento Save()
        {
            return new EditorMemento(Content);
        }

        // Restores state from a given memento.
        public void Restore(EditorMemento memento)
        {
            Content = memento.Content;
        }
    }
}
