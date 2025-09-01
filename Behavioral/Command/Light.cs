namespace DesignPattrens.Behavioral.Command
{
    // Receiver:
    // - The actual object that performs the work.
    // - Provides the business logic methods (TurnOn, TurnOff).
    public class Light
    {
        public void TurnOn() => Console.WriteLine("Light turned on");
        public void TurnOff() => Console.WriteLine("Light turned off");
    }
}
