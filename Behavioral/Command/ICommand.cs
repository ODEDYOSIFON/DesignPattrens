namespace DesignPattrens.Behavioral.Command
{
    // Command Interface:
    // - Declares the Execute method, implemented by all concrete commands.
    // - Ensures that different commands can be called uniformly.
    public interface ICommand
    {
        void Execute();
    }
}
