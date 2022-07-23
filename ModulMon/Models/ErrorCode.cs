using System;
using System.Collections.Generic;

namespace ModulMon.Models
{
    public partial class ErrorCode
    {
        public int ErrorCode1 { get; set; }
        public int ProjectId { get; set; }
        public string ShortDescription { get; set; } = null!;
        public string LongDescription { get; set; } = null!;
        public string CauseDescription { get; set; } = null!;
        public string ActionsTaken { get; set; } = null!;
        public bool OkStatus { get; set; }
        public DateTime LastFound { get; set; }
        public int ChangeUserId { get; set; }
        public DateTime ChangeTime { get; set; }
        public int NotificationThreshold { get; set; }

        public virtual Project Project { get; set; } = null!;
    }
}
