namespace DesignPattrens.Creational.Builder
{
    // Concrete Builder: implements the ICarBuilder interface.
    public class CarBuilder : ICarBuilder
    {
        // Internal car instance being assembled.
        private Car _car = new Car();

        // Implements each building step.
        public void SetEngine(string engine) => _car.Engine = engine;
        public void SetTyres(string tyres) => _car.Tyres = tyres;
        public void SetColor(string color) => _car.Color = color;

        // Returns the constructed Car.
        public Car Build() => _car;
    }
}
