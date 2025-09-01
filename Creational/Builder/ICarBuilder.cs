namespace DesignPattrens.Creational.Builder
{
    // Abstract Builder interface: defines the steps for creating a car.
    public interface ICarBuilder
    {
        // Each method sets a part of the Car product.
        void SetEngine(string engine);
        void SetTyres(string tyres);
        void SetColor(string color);

        // Final step: return the fully constructed Car.
        Car Build();
    }
}
