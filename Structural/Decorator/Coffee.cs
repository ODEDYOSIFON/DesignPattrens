namespace DesignPattrens.Structural.Decorator
{
    // Component:
    // - Defines the interface for objects that can have responsibilities added dynamically.
    // - Both base objects and decorators derive from this class.
    public abstract class Coffee
    {
        public abstract double GetCost();          // returns the cost
        public abstract string GetDescription();   // returns a textual description
    }
}
