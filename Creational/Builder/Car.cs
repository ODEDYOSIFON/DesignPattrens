namespace DesignPattrens.Creational.Builder
{
    // Product class: defines the object to be built by the Builder.
    public class Car
    {
        // Properties that will be set by the builder.
        public string Engine { get; set; }
        public string Tyres { get; set; }
        public string Color { get; set; }

        // Returns a textual description of the car's configuration.
        public override string ToString()
        {
            return $"Car with {Engine}, {Tyres}, and {Color} color";
        }
    }
}
