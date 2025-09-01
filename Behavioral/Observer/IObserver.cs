namespace DesignPattrens.Behavioral.Observer
{
    // Observer Interface:
    // - Declares the Update method to be called when the subject's state changes.
    // - All observers implement this interface.
    public interface IObserver
    {
        void Update(float temperature, float humidity, float pressure);
    }
}
