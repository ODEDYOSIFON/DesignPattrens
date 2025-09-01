namespace DesignPattrens.Creational.Builder
{
    // Director: defines the order of building steps.
    // It ensures a specific construction sequence without exposing details to clients.
    public class CarDirector
    {
        private ICarBuilder _builder;

        // Director takes a builder object (injected dependency).
        public CarDirector(ICarBuilder builder)
        {
            _builder = builder;
        }

        // Example of a construction sequence: building a sports car.
        public void ConstructSportsCar()
        {
            _builder.SetEngine("V8 Engine");   // define powerful engine
            _builder.SetTyres("Racing Tyres"); // add performance tyres
            _builder.SetColor("Red");          // assign sport-style color
        }
    }
}
