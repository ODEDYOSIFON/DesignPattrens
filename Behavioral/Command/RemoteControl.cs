namespace DesignPattrens.Behavioral.Command
{
    // Invoker:
    // - Triggers the command without knowing details about the action.
    // - Calls Execute() on the given ICommand.
    public class RemoteControl
    {
        public void Submit(ICommand command)
        {
            command.Execute();
        }
    }
}
