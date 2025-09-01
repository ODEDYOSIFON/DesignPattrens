namespace DesignPattrens.Behavioral.Command
{
    // Concrete Command:
    // - Encapsulates the action of turning off the Light.
    public class TurnOffCommand : ICommand
    {
        private readonly Light _light;

        public TurnOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOff(); // delegate action to the receiver
        }
    }
}
