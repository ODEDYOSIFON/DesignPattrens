namespace DesignPattrens.Structural.Facade
{
    // Facade:
    // - Provides a simplified interface to a complex subsystem.
    // - Orchestrates operations of multiple subsystem classes (Projector, DvdPlayer, SoundSystem).
    public class HomeTheaterFacade
    {
        private Projector _projector;
        private DvdPlayer _dvdPlayer;
        private SoundSystem _soundSystem;

        public HomeTheaterFacade(Projector projector, DvdPlayer dvdPlayer, SoundSystem soundSystem)
        {
            _projector = projector;
            _dvdPlayer = dvdPlayer;
            _soundSystem = soundSystem;
        }

        // Simplifies the process of starting a movie.
        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");
            _projector.On();
            _soundSystem.TurnOn();
            _dvdPlayer.Play(movie);
        }

        // Simplifies the process of ending a movie.
        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            _dvdPlayer.Stop();
            _soundSystem.TurnOff();
            _projector.Off();
        }
    }
}
