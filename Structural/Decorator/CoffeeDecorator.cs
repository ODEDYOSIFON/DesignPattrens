namespace DesignPattrens.Structural.Decorator
{
    // Decorator:
    // - Wraps a Coffee object.
    // - Implements the same interface and delegates calls to the wrapped object.
    // - Serves as the base class for all concrete decorators.
    public abstract class CoffeeDecorator : Coffee
    {
        protected Coffee _coffee;

        public CoffeeDecorator(Coffee coffee)
        {
            _coffee = coffee;
        }

        // Default behavior is to delegate to the wrapped object.
        public override double GetCost() => _coffee.GetCost();
        public override string GetDescription() => _coffee.GetDescription();
    }
}
