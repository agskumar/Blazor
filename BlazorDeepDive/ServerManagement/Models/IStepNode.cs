namespace ServerManagement.Models
{
    public interface IStepNode
    {
        string StepType { get; }
        IStepNode Clone();
    }
}