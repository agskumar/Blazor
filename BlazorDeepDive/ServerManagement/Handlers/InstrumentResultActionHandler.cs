using ServerManagement.Models;

namespace ServerManagement.Handlers
{
    public class InstrumentResultActionHandler : IActionHandler
    {
        public ActionType SupportedType => ActionType.InstrumentResult;

        public ActionModel CreateDefaultModel() => new InstrumentResultActionModel();
    }
}
