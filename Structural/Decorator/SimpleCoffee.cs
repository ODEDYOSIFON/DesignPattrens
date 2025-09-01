namespace DesignPattrens.Structural.Decorator
{
    // Concrete Component:
    // - A basic implementation of the component interface.
    // - Can be "decorated" by additional responsibilities at runtime.
    public class SimpleCoffee : Coffee
    {
        public override double GetCost() => 2.0;
        public override string GetDescription() => "Simple coffee";
    }
}
