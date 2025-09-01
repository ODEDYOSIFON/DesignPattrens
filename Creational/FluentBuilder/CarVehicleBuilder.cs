namespace DesignPattrens.Creational.FluentBuilder
{
    // Fluent Builder: constructs CarVehicle objects using chained method calls.
    public class CarVehicleBuilder
    {
        private CarVehicle _car = new CarVehicle();

        // Each "With..." method sets a property and returns the builder itself,
        // enabling fluent chaining.
        public CarVehicleBuilder WithEngine(string engine)
        {
            _car.Engine = engine;
            return this;
        }

        public CarVehicleBuilder WithTyres(string tyres)
        {
            _car.Tyres = tyres;
            return this;
        }

        public CarVehicleBuilder WithColor(string color)
        {
            _car.Color = color;
            return this;
        }

        // Final step: return the fully constructed product.
        public CarVehicle Build()
        {
            return _car;
        }
    }
}
