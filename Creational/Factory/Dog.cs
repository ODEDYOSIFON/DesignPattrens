namespace DesignPattrens.Creational.Factory
{
    // Concrete Product: implements IAnimal.
    public class Dog : IAnimal
    {
        // Dog-specific implementation of Speak().
        public string Speak() => "Bark!";
    }
}
