namespace DesignPattrens.Structural.Bridge
{
    // Implementor:
    // - Defines the interface for implementation classes.
    // - Concrete classes (SonyTV, SamsungTV) implement this interface.
    public interface ITV
    {
        void On();                       // Turn the TV on
        void Off();                      // Turn the TV off
        void SwitchChannel(int channel); // Switch to a given channel
    }
}
