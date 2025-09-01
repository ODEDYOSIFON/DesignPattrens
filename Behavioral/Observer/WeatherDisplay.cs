namespace DesignPattrens.Behavioral.Observer
{
    // Concrete Observer:
    // - Implements IObserver.
    // - Registers with the subject and updates its display whenever notified.
    public class WeatherDisplay : IObserver
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private ISubject weatherStation;

        public WeatherDisplay(ISubject weatherStation)
        {
            this.weatherStation = weatherStation;
        }

        // Observer subscribes to the subject.
        public void Subscribe()
        {
            weatherStation.RegisterObserver(this);
        }

        // Observer unsubscribes from the subject.
        public void Unsubscribe()
        {
            weatherStation.RemoveObserver(this);
        }

        // Called by subject when state changes.
        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();
        }

        // Displays current weather conditions.
        public void Display()
        {
            Console.WriteLine($"Current conditions: {temperature}F degrees and {humidity}% humidity and {pressure} pressure");
        }
    }
}
