using System;
using System.Collections.Generic;

namespace ModulMon.Models
{
    public partial class ProjectShiftSet
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string ShiftName { get; set; } = null!;
        public DateTime ShiftStartTime { get; set; }
        public DateTime ShiftEndTime { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public int ChangeUsrId { get; set; }
        public DateTime ChangeTime { get; set; }

        public virtual Project Project { get; set; } = null!;
    }
}
