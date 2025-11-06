using System.ComponentModel.DataAnnotations;

namespace ServerManagement.Models
{
    public enum ActionType
    {
        None,

        [Display(Name = "LIS Order")]
        LisOrder,

        [Display(Name = "Instrument Result")]
        InstrumentResult
    }
}
