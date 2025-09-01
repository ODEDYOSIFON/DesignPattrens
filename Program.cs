// Using directives import all namespaces where the design patterns are implemented.
using DesignPattrens.Behavioral.Command;
using DesignPattrens.Behavioral.Observer;
using DesignPattrens.Behavioral.Strategy;
using DesignPattrens.Creational.Builder;
using DesignPattrens.Creational.Factory;
using DesignPattrens.Creational.FluentBuilder;
using DesignPattrens.Creational.Memento;
using DesignPattrens.Structural.Bridge;
using DesignPattrens.Structural.Decorator;
using DesignPattrens.Structural.Facade;
using DesignPattrens.Structural.Flyweight;
// Resolve name conflict: Command.RemoteControl is aliased here
using RemoteControl = DesignPattrens.Behavioral.Command.RemoteControl;

class Program
{
    static void Main(string[] args)
    {
        // -------- Factory Pattern --------
        // Factory returns an object without exposing creation logic.
        IAnimal animal = AnimalFactory.CreateAnimal("Dog");
        Console.WriteLine(animal.Speak()); // Output: Bark!

        // -------- Builder Pattern --------
        // Builder separates construction steps from representation.
        CarBuilder builder = new CarBuilder();
        CarDirector director = new CarDirector(builder);

        director.ConstructSportsCar(); // director defines steps for a sports car
        Car car = builder.Build();     // builder assembles the car
        Console.WriteLine(car.ToString());

        // -------- Fluent Builder Pattern --------
        // Fluent Builder enables chained configuration.
        CarVehicle carV = new CarVehicleBuilder()
               .WithEngine("V8 Engine")
               .WithTyres("Racing Tyres")
               .WithColor("Red")
               .Build();
        Console.WriteLine(carV.ToString());

        // -------- Strategy Pattern --------
        // Strategy lets us change algorithms at runtime.
        var data = new List<int> { 5, 3, 2, 4, 1 };

        var sortedList = new SortedList(new BubbleSortStrategy());
        sortedList.Sort(data); // Bubble sort

        sortedList = new SortedList(new QuickSortStrategy());
        sortedList.Sort(data); // Quick sort

        // -------- Command Pattern --------
        // Command encapsulates actions (turning a light on/off).
        var light = new Light();
        var turnOnCommand = new TurnOnCommand(light);
        var turnOffCommand = new TurnOffCommand(light);

        var remote = new RemoteControl();
        remote.Submit(turnOnCommand);  // executes Light.On()
        remote.Submit(turnOffCommand); // executes Light.Off()

        // -------- Memento Pattern --------
        // Memento captures and restores object state.
        var editor = new Editor();
        var history = new History();

        editor.Content = "This is the first sentence.";
        history.SaveState(editor.Save()); // save snapshot

        editor.Content = "This is the second sentence.";
        history.SaveState(editor.Save());

        editor.Restore(history.RestoreState()); // rollback to previous state
        Console.WriteLine(editor.Content);

        // -------- Flyweight Pattern --------
        // Flyweight shares objects to save memory.
        var factory = new TreeModelFactory();

        var oakTree = factory.GetTreeModel("Oak");
        oakTree.Render(1, 2, 3, 10.0, 5.0);

        var pineTree = factory.GetTreeModel("Pine");
        pineTree.Render(5, 6, 7, 15.0, 7.0);

        var anotherOakTree = factory.GetTreeModel("Oak");
        anotherOakTree.Render(9, 10, 11, 12.0, 6.0);

        // -------- Facade Pattern --------
        // Facade provides a simplified interface.
        var homeTheater = new HomeTheaterFacade(new Projector(), new DvdPlayer(), new SoundSystem());
        homeTheater.WatchMovie("Inception");
        homeTheater.EndMovie();

        // -------- Observer Pattern --------
        // Observer notifies dependent objects when state changes.
        WeatherStation weatherStation = new WeatherStation();
        WeatherDisplay currentDisplay = new WeatherDisplay(weatherStation);

        currentDisplay.Subscribe();
        weatherStation.SetMeasurements(80, 65, 30.4f);

        currentDisplay.Unsubscribe();
        weatherStation.SetMeasurements(82, 70, 29.2f); // no update shown

        // -------- Decorator Pattern --------
        // Decorator adds behavior dynamically.
        Coffee simpleCoffee = new SimpleCoffee();
        Console.WriteLine($"{simpleCoffee.GetDescription()}:\t${simpleCoffee.GetCost()}");

        Coffee milkCoffee = new MilkDecorator(simpleCoffee);
        Console.WriteLine($"{milkCoffee.GetDescription()}:\t${milkCoffee.GetCost()}");

        Coffee milkSugarCoffee = new SugarDecorator(milkCoffee);
        Console.WriteLine($"{milkSugarCoffee.GetDescription()}:\t${milkSugarCoffee.GetCost()}");

        // -------- Bridge Pattern --------
        // Bridge decouples abstraction (remote) from implementation (TV).
        ITV sonyTv = new SonyTV();
        DesignPattrens.Structural.Bridge.RemoteControl standardRemote = new StandardRemote(sonyTv);

        standardRemote.TurnOn();
        standardRemote.SetChannel(5);
        standardRemote.TurnOff();

        // -------- Composite Pattern --------
        // Composite treats single objects and compositions uniformly.
        var root = new DesignPattrens.Structural.Composite.Directory("root");
        var file1 = new DesignPattrens.Structural.Composite.File("file1.txt");
        var file2 = new DesignPattrens.Structural.Composite.File("file2.txt");
        var subDirectory = new DesignPattrens.Structural.Composite.Directory("subdir");
        var file3 = new DesignPattrens.Structural.Composite.File("file3.txt");

        root.Add(file1);
        root.Add(subDirectory);
        subDirectory.Add(file2);
        subDirectory.Add(file3);

        root.Print(); // prints full tree
    }
}
