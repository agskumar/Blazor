using System.ComponentModel.DataAnnotations;
using ServerManagement.Models;

namespace ServerManagement.Models
{
    public abstract class ExpectationModel : IStepNode
    {
        public abstract ExpectationType Type { get; set; }
        public string StepType => Type.ToString();
        public virtual ExpectationModel Clone() => (ExpectationModel)MemberwiseClone();
        IStepNode IStepNode.Clone() => Clone();
    }

    public enum ExpectationType
    {
        None,
        ResultValue,
        ResultComments,
        ResultStatus,
        ResultCritical,
        LastRunComments,
        TestStatus,
        TestAnalysisMethod,
        SamplePriority,
        SampleTag,
        SampleAssignment,
        SampleComments,
        OrderStatus,
        OrderTag,
        PatientTag
    }

    public class ResultValueExpectationModel : ExpectationModel
    {
        public override ExpectationType Type { get; set; } = ExpectationType.ResultValue;

        [Required(ErrorMessage = "Sample ID is required")]
        public string? SampleId { get; set; }

        [Required(ErrorMessage = "Parameter code is required")]
        public string? ParameterCode { get; set; }

        [Required(ErrorMessage = "Comparator is required")]
        public string? Comparator { get; set; }

        [Required(ErrorMessage = "Value is required")]
        public string? Value { get; set; }

        public override ExpectationModel Clone()
        {
            return new ResultValueExpectationModel
            {
                Type = this.Type,
                SampleId = this.SampleId,
                ParameterCode = this.ParameterCode,
                Comparator = this.Comparator,
                Value = this.Value
            };
        }
    }

    public class ResultCommentsExpectationModel : ExpectationModel
    {
        public override ExpectationType Type { get; set; } = ExpectationType.ResultComments;

        [Required(ErrorMessage = "Sample ID is required")]
        public string? SampleId { get; set; }

        [Required(ErrorMessage = "Parameter code is required")]
        public string? ParameterCode { get; set; }

        [Required(ErrorMessage = "Comparator is required")]
        public string? Comparator { get; set; }

        [Required(ErrorMessage = "Value is required")]
        public string? Value { get; set; }

        public override ExpectationModel Clone()
        {
            return new ResultCommentsExpectationModel
            {
                Type = this.Type,
                SampleId = this.SampleId,
                ParameterCode = this.ParameterCode,
                Comparator = this.Comparator,
                Value = this.Value
            };
        }
    }

    public class ResultStatusExpectationModel : ExpectationModel
    {
        public override ExpectationType Type { get; set; } = ExpectationType.ResultStatus;

        [Required(ErrorMessage = "Sample ID is required")]
        public string? SampleId { get; set; }

        [Required(ErrorMessage = "Parameter code is required")]
        public string? ParameterCode { get; set; }

        public string? PositionBeforeLast { get; set; }

        [Required(ErrorMessage = "Value is required")]
        public string? Value { get; set; }

        public override ExpectationModel Clone()
        {
            return new ResultStatusExpectationModel
            {
                Type = this.Type,
                SampleId = this.SampleId,
                ParameterCode = this.ParameterCode,
                PositionBeforeLast = this.PositionBeforeLast,
                Value = this.Value
            };
        }
    }

    public class ResultCriticalExpectationModel : ExpectationModel
    {
        public override ExpectationType Type { get; set; } = ExpectationType.ResultCritical;

        [Required(ErrorMessage = "Sample ID is required")]
        public string? SampleId { get; set; }

        [Required(ErrorMessage = "Parameter code is required")]
        public string? ParameterCode { get; set; }

        [Required(ErrorMessage = "Value is required")]
        public string? Value { get; set; }

        public override ExpectationModel Clone()
        {
            return new ResultCriticalExpectationModel
            {
                Type = this.Type,
                SampleId = this.SampleId,
                ParameterCode = this.ParameterCode,
                Value = this.Value
            };
        }
    }

    public class LastRunCommentsExpectationModel : ExpectationModel
    {
        public override ExpectationType Type { get; set; } = ExpectationType.LastRunComments;

        [Required(ErrorMessage = "Sample ID is required")]
        public string? SampleId { get; set; }

        [Required(ErrorMessage = "Comparator is required")]
        public string? Comparator { get; set; }

        [Required(ErrorMessage = "Value is required")]
        public string? Value { get; set; }

        public override ExpectationModel Clone()
        {
            return new LastRunCommentsExpectationModel
            {
                Type = this.Type,
                SampleId = this.SampleId,
                Comparator = this.Comparator,
                Value = this.Value
            };
        }
    }

    public class TestStatusExpectationModel : ExpectationModel
    {
        public override ExpectationType Type { get; set; } = ExpectationType.TestStatus;

        [Required(ErrorMessage = "Sample ID is required")]
        public string? SampleId { get; set; }

        [Required(ErrorMessage = "Parameter code is required")]
        public string? ParameterCode { get; set; }

        [Required(ErrorMessage = "Value is required")]
        public string? Value { get; set; }

        public override ExpectationModel Clone()
        {
            return new TestStatusExpectationModel
            {
                Type = this.Type,
                SampleId = this.SampleId,
                ParameterCode = this.ParameterCode,
                Value = this.Value
            };
        }
    }

    public class TestAnalysisMethodExpectationModel : ExpectationModel
    {
        public override ExpectationType Type { get; set; } = ExpectationType.TestAnalysisMethod;

        [Required(ErrorMessage = "Sample ID is required")]
        public string? SampleId { get; set; }

        [Required(ErrorMessage = "Parameter code is required")]
        public string? ParameterCode { get; set; }

        [Required(ErrorMessage = "Value is required")]
        public string? Value { get; set; }

        public override ExpectationModel Clone()
        {
            return new TestAnalysisMethodExpectationModel
            {
                Type = this.Type,
                SampleId = this.SampleId,
                ParameterCode = this.ParameterCode,
                Value = this.Value
            };
        }
    }

    public class SamplePriorityExpectationModel : ExpectationModel
    {
        public override ExpectationType Type { get; set; } = ExpectationType.SamplePriority;

        [Required(ErrorMessage = "Sample ID is required")]
        public string? SampleId { get; set; }

        [Required(ErrorMessage = "Value is required")]
        public string? Value { get; set; }

        public override ExpectationModel Clone()
        {
            return new SamplePriorityExpectationModel
            {
                Type = this.Type,
                SampleId = this.SampleId,
                Value = this.Value
            };
        }
    }

    public class SampleTagExpectationModel : ExpectationModel
    {
        public override ExpectationType Type { get; set; } = ExpectationType.SampleTag;

        [Required(ErrorMessage = "Sample ID is required")]
        public string? SampleId { get; set; }

        [Required(ErrorMessage = "Value is required")]
        public string? Value { get; set; }

        public override ExpectationModel Clone()
        {
            return new SampleTagExpectationModel
            {
                Type = this.Type,
                SampleId = this.SampleId,
                Value = this.Value
            };
        }
    }

    public class SampleAssignmentExpectationModel : ExpectationModel
    {
        public override ExpectationType Type { get; set; } = ExpectationType.SampleAssignment;

        [Required(ErrorMessage = "Sample ID is required")]
        public string? SampleId { get; set; }

        [Required(ErrorMessage = "Value is required")]
        public string? Value { get; set; }

        public override ExpectationModel Clone()
        {
            return new SampleAssignmentExpectationModel
            {
                Type = this.Type,
                SampleId = this.SampleId,
                Value = this.Value
            };
        }
    }

    public class SampleCommentsExpectationModel : ExpectationModel
    {
        public override ExpectationType Type { get; set; } = ExpectationType.SampleComments;

        [Required(ErrorMessage = "Sample ID is required")]
        public string? SampleId { get; set; }

        [Required(ErrorMessage = "Comparator is required")]
        public string? Comparator { get; set; }

        [Required(ErrorMessage = "Value is required")]
        public string? Value { get; set; }

        public override ExpectationModel Clone()
        {
            return new SampleCommentsExpectationModel
            {
                Type = this.Type,
                SampleId = this.SampleId,
                Comparator = this.Comparator,
                Value = this.Value
            };
        }
    }

    public class OrderStatusExpectationModel : ExpectationModel
    {
        public override ExpectationType Type { get; set; } = ExpectationType.OrderStatus;

        [Required(ErrorMessage = "Sample ID is required")]
        public string? SampleId { get; set; }

        [Required(ErrorMessage = "Value is required")]
        public string? Value { get; set; }

        public override ExpectationModel Clone()
        {
            return new OrderStatusExpectationModel
            {
                Type = this.Type,
                SampleId = this.SampleId,
                Value = this.Value
            };
        }
    }

    public class OrderTagExpectationModel : ExpectationModel
    {
        public override ExpectationType Type { get; set; } = ExpectationType.OrderTag;

        [Required(ErrorMessage = "Sample ID is required")]
        public string? SampleId { get; set; }

        [Required(ErrorMessage = "Value is required")]
        public string? Value { get; set; }

        public override ExpectationModel Clone()
        {
            return new OrderTagExpectationModel
            {
                Type = this.Type,
                SampleId = this.SampleId,
                Value = this.Value
            };
        }
    }

    public class PatientTagExpectationModel : ExpectationModel
    {
        public override ExpectationType Type { get; set; } = ExpectationType.PatientTag;

        [Required(ErrorMessage = "Sample ID is required")]
        public string? SampleId { get; set; }

        public override ExpectationModel Clone()
        {
            return new PatientTagExpectationModel
            {
                Type = this.Type,
                SampleId = this.SampleId
            };
        }
    }

    public class EmptyExpectation : ExpectationModel
    {
        public override ExpectationType Type { get; set; } = ExpectationType.None;
        public override ExpectationModel Clone() => new EmptyExpectation { Type = this.Type };
    }
}