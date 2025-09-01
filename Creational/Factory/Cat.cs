namespace DesignPattrens.Creational.Factory
{
    // Concrete Product: implements IAnimal.
    public class Cat : IAnimal
    {
        // Cat-specific implementation of Speak().
        public string Speak() => "Meow";
    }
}
