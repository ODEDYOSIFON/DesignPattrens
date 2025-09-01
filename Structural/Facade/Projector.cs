namespace DesignPattrens.Structural.Facade
{
    // Subsystem:
    // - Represents one part of the complex subsystem.
    // - Provides operations to turn the projector on and off.
    public class Projector
    {
        public void On() => Console.WriteLine("Projector on");
        public void Off() => Console.WriteLine("Projector off");
    }
}
