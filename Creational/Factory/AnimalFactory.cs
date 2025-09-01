namespace DesignPattrens.Creational.Factory
{
    // Creator / Factory: encapsulates object creation.
    public static class AnimalFactory
    {
        // Chooses which concrete class to instantiate based on input.
        public static IAnimal CreateAnimal(string type)
        {
            return type switch
            {
                "Dog" => new Dog(), // returns a Dog
                "Cat" => new Cat(), // returns a Cat
                _ => throw new ArgumentException("Invalid type", nameof(type))
            };
        }
    }
}
