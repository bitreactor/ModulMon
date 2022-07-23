using System;
using System.Collections.Generic;

namespace ModulMon.Models
{
    public partial class Notification
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int Station { get; set; }
        public DateTime NotificationTime { get; set; }
        public int ErrorCode { get; set; }

        public virtual Project Project { get; set; } = null!;
    }
}
