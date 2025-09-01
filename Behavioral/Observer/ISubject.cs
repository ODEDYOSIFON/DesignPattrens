namespace DesignPattrens.Behavioral.Observer
{
    // Subject Interface:
    // - Declares methods for attaching, detaching, and notifying observers.
    public interface ISubject
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }
}
