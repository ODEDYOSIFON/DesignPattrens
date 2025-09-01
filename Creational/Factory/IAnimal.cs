namespace DesignPattrens.Creational.Factory
{
    // Abstract Product: defines the contract for all animals.
    public interface IAnimal
    {
        // Each animal must implement Speak(), returning its sound.
        string Speak();
    }
}
