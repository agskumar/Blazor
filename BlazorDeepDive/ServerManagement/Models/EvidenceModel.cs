using ServerManagement.Models;
using System.ComponentModel.DataAnnotations;

public abstract class EvidenceModel : IStepNode
{
    public abstract EvidenceType Type { get; set; }

    [Required(ErrorMessage = "Sample ID is required.")]
    public string SampleId { get; set; } = string.Empty;
    public string StepType => nameof(EvidenceModel);

    public virtual EvidenceModel Clone()
    {
        var clone = (EvidenceModel)MemberwiseClone();
        return clone;
    }

    IStepNode IStepNode.Clone() => Clone();
}

public class AllSampleInfoEvidenceModel : EvidenceModel
{
    public override EvidenceType Type { get; set; } = EvidenceType.AllSampleInfo;
}

public class LastRunResultsEvidenceModel : EvidenceModel
{
    public override EvidenceType Type { get; set; } = EvidenceType.LastRunResults;
}

public class AllRunResultsEvidenceModel : EvidenceModel
{
    public override EvidenceType Type { get; set; } = EvidenceType.AllRunResults;
}

public class LastRunRulesEvidenceModel : EvidenceModel
{
    public override EvidenceType Type { get; set; } = EvidenceType.LastRunRules;
}

public class LastRunEffectiveRulesEvidenceModel : EvidenceModel
{
    public override EvidenceType Type { get; set; } = EvidenceType.LastRunEffectiveRules;
}

public class AllSampleRulesEvidenceModel : EvidenceModel
{
    public override EvidenceType Type { get; set; } = EvidenceType.AllSampleRules;
}

public class AllSampleEffectiveRulesEvidenceModel : EvidenceModel
{
    public override EvidenceType Type { get; set; } = EvidenceType.AllSampleEffectiveRules;
}

public class LastRunResultsHistoryEvidenceModel : EvidenceModel
{
    public override EvidenceType Type { get; set; } = EvidenceType.LastRunResultsHistory;
}

public class AllSampleHistoryEvidenceModel : EvidenceModel
{
    public override EvidenceType Type { get; set; } = EvidenceType.AllSampleHistory;
}

public class FullOrderEvidenceModel : EvidenceModel
{
    public override EvidenceType Type { get; set; } = EvidenceType.FullOrder;
}

public class EmptyEvidence : EvidenceModel
{
    public override EvidenceType Type { get; set; } = EvidenceType.None;
}