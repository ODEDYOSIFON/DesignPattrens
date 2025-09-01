namespace DesignPattrens.Structural.Decorator
{
    // Concrete Decorator:
    // - Adds sugar to the coffee.
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(Coffee coffee) : base(coffee) { }

        public override double GetCost() => base.GetCost() + 0.3;
        public override string GetDescription() => base.GetDescription() + ", sugar";
    }
}
