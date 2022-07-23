using System;
using System.Collections.Generic;

namespace ModulMon.Models
{
    public partial class VerificationSample
    {
        public VerificationSample()
        {
            VerificationErrorCodes = new HashSet<VerificationErrorCode>();
        }

        public int SampleId { get; set; }
        public int LineId { get; set; }
        public int SampleNumber { get; set; }
        public string MaterialNumber { get; set; } = null!;
        public int ProgramNumber { get; set; }
        public string ErrorDescription { get; set; } = null!;
        public string Note { get; set; } = null!;

        public virtual Line Line { get; set; } = null!;
        public virtual ICollection<VerificationErrorCode> VerificationErrorCodes { get; set; }
    }
}
