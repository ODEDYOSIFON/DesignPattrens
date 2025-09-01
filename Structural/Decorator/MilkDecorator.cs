namespace DesignPattrens.Structural.Decorator
{
    // Concrete Decorator:
    // - Adds milk to the coffee.
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(Coffee coffee) : base(coffee) { }

        public override double GetCost() => base.GetCost() + 0.5;
        public override string GetDescription() => base.GetDescription() + ", milk";
    }
}
