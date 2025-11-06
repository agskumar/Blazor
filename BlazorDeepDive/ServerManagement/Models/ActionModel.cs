namespace ServerManagement.Models
{
    public abstract class ActionModel
    {
        public ActionType Type { get; set; } = ActionType.None;

        // simple clone pattern — override in derived types if needed
        public virtual ActionModel Clone()
        {
            // shallow copy is ok for current simple string fields
            return (ActionModel)MemberwiseClone();
        }
    }

    public class LisOrderActionModel : ActionModel
    {
        public LisOrderActionModel() => Type = ActionType.LisOrder;

        public string? Source { get; set; }
        public string? SampleId { get; set; }
        public string? Test { get; set; }

        public override ActionModel Clone()
        {
            return new LisOrderActionModel
            {
                Type = this.Type,
                Source = this.Source,
                SampleId = this.SampleId,
                Test = this.Test
            };
        }
    }

    public class InstrumentResultActionModel : ActionModel
    {
        public InstrumentResultActionModel() => Type = ActionType.InstrumentResult;

        public string? SampleId { get; set; }
        public string? Priority { get; set; }
        public string? PatientId { get; set; }
        public string? PatientLastName { get; set; }
        public string? PatientFirstName { get; set; }
        public string? PatientSex { get; set; }
        public string? PatientBirthdate { get; set; }
        public string? Rack { get; set; }
        public string? Position { get; set; }

        public override ActionModel Clone()
        {
            return new InstrumentResultActionModel
            {
                Type = this.Type,
                SampleId = this.SampleId,
                Priority = this.Priority,
                PatientId = this.PatientId,
                PatientLastName = this.PatientLastName,
                PatientFirstName = this.PatientFirstName,
                PatientSex = this.PatientSex,
                PatientBirthdate = this.PatientBirthdate,
                Rack = this.Rack,
                Position = this.Position
            };
        }
    }

    // simple empty placeholder model (used when None)
    public class EmptyAction : ActionModel
    {
        public EmptyAction() => Type = ActionType.None;
        public override ActionModel Clone() => new EmptyAction { Type = this.Type };
    }
}
