namespace DesignPattrens.Structural.Facade
{
    // Subsystem:
    // - Represents another subsystem (DVD player).
    // - Handles playing and stopping movies.
    public class DvdPlayer
    {
        public void Play(string movie) => Console.WriteLine($"Playing \"{movie}\"");
        public void Stop() => Console.WriteLine("Stop the movie");
    }
}
