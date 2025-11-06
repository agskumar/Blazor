using ServerManagement.Components.Controls;

namespace ServerManagement.Models
{
    /// <summary>
    /// Registry mapping ActionType to the razor component Type that should render it.
    /// Register new mappings here when you add new action UI components.
    /// </summary>
    public static class ActionRegistry
    {
        private static readonly Dictionary<ActionType, Type> _map = new();

        static ActionRegistry()
        {
            _map[ActionType.LisOrder] = typeof(ServerManagement.Components.Controls.LisOrder);
            _map[ActionType.InstrumentResult] = typeof(ServerManagement.Components.Controls.InstrumentResult);
        }

        public static Type? GetComponentType(ActionType type)
            => _map.TryGetValue(type, out var t) ? t : null;

        public static void Register(ActionType type, Type componentType)
        {
            _map[type] = componentType;
        }
    }
}
