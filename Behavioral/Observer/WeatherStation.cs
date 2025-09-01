namespace DesignPattrens.Behavioral.Observer
{
    // Concrete Subject:
    // - Stores the state (temperature, humidity, pressure).
    // - Maintains a list of observers and notifies them when state changes.
    public class WeatherStation : ISubject
    {
        private List<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherStation()
        {
            observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver o) => observers.Add(o);
        public void RemoveObserver(IObserver o) => observers.Remove(o);

        // Notifies all registered observers with current state.
        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }

        // Helper: triggers notifications when state changes.
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        // Updates internal state and notifies observers.
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
    }
}
