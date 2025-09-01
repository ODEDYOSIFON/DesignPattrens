namespace DesignPattrens.Structural.Bridge
{
    // Refined Abstraction:
    // - Extends the interface defined by Abstraction (RemoteControl).
    // - Delegates actual work to the implementor (ITV).
    public class StandardRemote : RemoteControl
    {
        public StandardRemote(ITV tv) : base(tv) { }

        public override void TurnOn() => tv.On();
        public override void TurnOff() => tv.Off();
        public override void SetChannel(int channel) => tv.SwitchChannel(channel);
    }
}
