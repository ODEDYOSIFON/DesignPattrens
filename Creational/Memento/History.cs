namespace DesignPattrens.Creational.Memento
{
    // Caretaker:
    // - Manages and stores Mementos.
    // - Does not modify or inspect the contents of the mementos.
    // - Provides save/restore operations for Originator's states.
    public class History
    {
        private Stack<EditorMemento> _history = new Stack<EditorMemento>();

        // Save a snapshot into the history stack.
        public void SaveState(EditorMemento memento)
        {
            _history.Push(memento);
        }

        // Restore the most recent snapshot (undo).
        public EditorMemento RestoreState()
        {
            return _history.Pop();
        }
    }
}
