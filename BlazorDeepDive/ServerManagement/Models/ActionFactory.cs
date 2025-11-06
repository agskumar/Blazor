namespace ServerManagement.Models
{
    public static class ActionFactory
    {
        public static ActionModel Create(ActionType type)
        {
            return type switch
            {
                ActionType.LisOrder => new LisOrderActionModel(),
                ActionType.InstrumentResult => new InstrumentResultActionModel(),
                _ => new EmptyAction(),
            };
        }
    }
}
