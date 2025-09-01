namespace DesignPattrens.Structural.Bridge
{
    // Abstraction:
    // - Maintains a reference to the implementor (ITV).
    // - Declares high-level operations that rely on implementor methods.
    public abstract class RemoteControl
    {
        protected ITV tv; // reference to an implementor

        public RemoteControl(ITV tv)
        {
            this.tv = tv;
        }

        public abstract void TurnOn();
        public abstract void TurnOff();
        public abstract void SetChannel(int channel);
    }
}
