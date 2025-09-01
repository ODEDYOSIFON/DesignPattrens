namespace DesignPattrens.Structural.Bridge
{
    // Concrete Implementor:
    // - Implements the ITV interface with brand-specific behavior.
    public class SamsungTV : ITV
    {
        public void On() => Console.WriteLine("Samsung TV: Turned On");
        public void Off() => Console.WriteLine("Samsung TV: Turned Off");
        public void SwitchChannel(int channel) => Console.WriteLine($"Samsung TV: Set channel to {channel}");
    }
}
