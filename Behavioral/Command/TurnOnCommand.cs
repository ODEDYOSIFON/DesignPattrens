namespace DesignPattrens.Behavioral.Command
{
    // Concrete Command:
    // - Implements the ICommand interface.
    // - Encapsulates the action of turning on the Light (receiver).
    public class TurnOnCommand : ICommand
    {
        private readonly Light _light;

        public TurnOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn(); // delegate action to the receiver
        }
    }
}
