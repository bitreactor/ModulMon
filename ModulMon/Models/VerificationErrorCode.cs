using System;
using System.Collections.Generic;

namespace ModulMon.Models
{
    public partial class VerificationErrorCode
    {
        public int Id { get; set; }
        public int SampleId { get; set; }
        public int ErrorCode { get; set; }
        public int ErrorStepNumber { get; set; }
        public int ErrorActionNumber { get; set; }
        public string ErrorDescription { get; set; } = null!;
        public string Note { get; set; } = null!;

        public virtual VerificationSample Sample { get; set; } = null!;
    }
}
