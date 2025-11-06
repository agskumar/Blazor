using ServerManagement.Models;

namespace ServerManagement.Handlers
{
    public class LisOrderActionHandler : IActionHandler
    {
        public ActionType SupportedType => ActionType.LisOrder;

        public ActionModel CreateDefaultModel() => new LisOrderActionModel();
    }
}
