using ServerManagement.Models;

namespace ServerManagement.Handlers
{
    public interface IActionHandler
    {
        ActionType SupportedType { get; }
        ActionModel CreateDefaultModel();
    }
}
