namespace DesignPattrens.Creational.FluentBuilder
{
    // Product: the object we want to construct using a fluent builder.
    public class CarVehicle
    {
        // Properties configured by the builder.
        public string Engine { get; set; }
        public string Tyres { get; set; }
        public string Color { get; set; }

        // Provides a readable summary of the configuration.
        public override string ToString()
        {
            return $"Car with {Engine}, {Tyres}, and {Color} color";
        }
    }
}

