using System.ComponentModel.DataAnnotations;
using ServerManagement.Validation;

namespace ServerManagement.Models
{
    public abstract class ActionModel :IStepNode
    {
        public ActionType Type { get; set; } = ActionType.None;

        public virtual ActionModel Clone()
        {
            // shallow copy 
            return (ActionModel)MemberwiseClone();
        }

        // Explicit interface implementation for IStepNode
        IStepNode IStepNode.Clone() => Clone();
        public string StepType => Type.ToString();
    }

    public class LisOrderActionModel : ActionModel
    {
        public LisOrderActionModel() => Type = ActionType.LisOrder;

        // Section 1: Sample Informations
        [Required(ErrorMessage = "Source LIS is required")]
        public string? SourceLIS { get; set; }

        [Required(ErrorMessage = "Sample ID is required")]
        public string? SampleId { get; set; }

        [MinimumCount(1, ErrorMessage = "At least one parameter code must be selected")]
        public List<string> ParameterCodes { get; set; } = new();

        public string Priority { get; set; } = "Routine";

        public DateTime? DrawingDate { get; set; }

        public DateTime? DrawingTime { get; set; }

        public string? Doctor { get; set; }

        public string? InterpretationComment { get; set; }

        public string? TechnicalComment { get; set; }

        // Section 2: Patient Informations
        public string? PatientId { get; set; }

        public string? PatientLastName { get; set; }

        public string? PatientFirstName { get; set; }

        public string PatientSex { get; set; } = "Unknown";

        public DateTime? PatientBirthdate { get; set; }

        public string? Department { get; set; }

        public string? ClinicalComment { get; set; }

        public override ActionModel Clone()
        {
            return new LisOrderActionModel
            {
                Type = this.Type,
                SourceLIS = this.SourceLIS,
                SampleId = this.SampleId,
                ParameterCodes = new List<string>(this.ParameterCodes),
                Priority = this.Priority,
                DrawingDate = this.DrawingDate,
                DrawingTime = this.DrawingTime,
                Doctor = this.Doctor,
                InterpretationComment = this.InterpretationComment,
                TechnicalComment = this.TechnicalComment,
                PatientId = this.PatientId,
                PatientLastName = this.PatientLastName,
                PatientFirstName = this.PatientFirstName,
                PatientSex = this.PatientSex,
                PatientBirthdate = this.PatientBirthdate,
                Department = this.Department,
                ClinicalComment = this.ClinicalComment
            };
        }
    }

    public class InstrumentResultActionModel : ActionModel
    {
        public InstrumentResultActionModel() => Type = ActionType.InstrumentResult;

        // Section 1: Sample
        [Required(ErrorMessage = "Source Analyzer is required")]
        public string? SourceAnalyzer { get; set; }

        [Required(ErrorMessage = "Sample ID is required")]
        public string? SampleId { get; set; }

        public string Priority { get; set; } = "Routine";

        public string? Rack { get; set; }

        public string? Position { get; set; }

        // Section 2: Patient
        public bool ShowPatient { get; set; } = false;

        public string? PatientId { get; set; }

        public string? PatientLastName { get; set; }

        public string? PatientFirstName { get; set; }

        public string PatientSex { get; set; } = "Unknown";

        public DateTime? PatientBirthdate { get; set; }

        // Section 3: Run Comments
        public List<RunComment> RunComments { get; set; } = new();

        // Section 4: Results
        public List<ResultItem> Results { get; set; } = new();

        public override ActionModel Clone()
        {
            return new InstrumentResultActionModel
            {
                Type = this.Type,
                SourceAnalyzer = this.SourceAnalyzer,
                SampleId = this.SampleId,
                Priority = this.Priority,
                Rack = this.Rack,
                Position = this.Position,
                ShowPatient = this.ShowPatient,
                PatientId = this.PatientId,
                PatientLastName = this.PatientLastName,
                PatientFirstName = this.PatientFirstName,
                PatientSex = this.PatientSex,
                PatientBirthdate = this.PatientBirthdate,
                RunComments = this.RunComments.Select(c => c.Clone()).ToList(),
                Results = this.Results.Select(r => r.Clone()).ToList()
            };
        }
    }

    public class RunComment
    {
        public string CommentType { get; set; } = "Others";
        public string? CommentText { get; set; }

        public RunComment Clone()
        {
            return new RunComment
            {
                CommentType = this.CommentType,
                CommentText = this.CommentText
            };
        }
    }

    public class ResultItem
    {
        public string? ParameterCode { get; set; }
        public string? Value { get; set; }
        public List<RunComment> Comments { get; set; } = new();

        public ResultItem Clone()
        {
            return new ResultItem
            {
                ParameterCode = this.ParameterCode,
                Value = this.Value,
                Comments = this.Comments.Select(c => c.Clone()).ToList()
            };
        }
    }

    public class EmptyAction : ActionModel
    {
        public EmptyAction() => Type = ActionType.None;
        public override ActionModel Clone() => new EmptyAction { Type = this.Type };
    }
}