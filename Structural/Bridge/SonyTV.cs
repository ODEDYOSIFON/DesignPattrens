namespace DesignPattrens.Structural.Bridge
{
    // Concrete Implementor:
    // - Another brand-specific implementation of ITV.
    public class SonyTV : ITV
    {
        public void On() => Console.WriteLine("Sony TV: Turned On");
        public void Off() => Console.WriteLine("Sony TV: Turned Off");
        public void SwitchChannel(int channel) => Console.WriteLine($"Sony TV: Set channel to {channel}");
    }
}
