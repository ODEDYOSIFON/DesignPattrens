namespace DesignPattrens.Structural.Flyweight
{
    // Flyweight:
    // - Represents the shared object containing intrinsic (internal) state.
    // - Intrinsic state (Texture, Model) is shared across many trees.
    // - Extrinsic state (position, dimensions) is passed in as method parameters.
    public class TreeModel
    {
        // Intrinsic state (shared among all trees of the same type).
        public string Texture { get; set; }
        public string Model { get; set; }

        // Extrinsic state: unique per tree instance, passed at runtime.
        public void Render(int x, int y, int z, double height, double width)
        {
            Console.WriteLine($"Rendering a tree at ({x}, {y}, {z}) with height {height} and width {width}");
            // Rendering logic would combine shared Texture/Model with given coordinates/dimensions.
        }
    }
}
