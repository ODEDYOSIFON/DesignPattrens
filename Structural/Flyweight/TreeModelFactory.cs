namespace DesignPattrens.Structural.Flyweight
{
    // Flyweight Factory:
    // - Creates and manages TreeModel objects.
    // - Ensures that models of the same type are shared instead of duplicated.
    public class TreeModelFactory
    {
        private Dictionary<string, TreeModel> _models = new Dictionary<string, TreeModel>();

        // Returns a shared TreeModel instance for the given type.
        // If not already created, it initializes and caches it.
        public TreeModel GetTreeModel(string type)
        {
            if (!_models.ContainsKey(type))
            {
                var model = new TreeModel
                {
                    Texture = type + "-texture",
                    Model = type + "-model"
                };
                _models[type] = model;
            }

            return _models[type];
        }
    }
}
