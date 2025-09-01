namespace DesignPattrens.Structural.Facade
{
    // Subsystem:
    // - Represents the sound system.
    // - Provides operations to turn it on or off.
    public class SoundSystem
    {
        public void TurnOn() => Console.WriteLine("Sound system on");
        public void TurnOff() => Console.WriteLine("Sound system off");
    }
}
