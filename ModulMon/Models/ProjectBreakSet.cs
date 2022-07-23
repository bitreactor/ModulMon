using System;
using System.Collections.Generic;

namespace ModulMon.Models
{
    public partial class ProjectBreakSet
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Name { get; set; } = null!;
        public DateTime StartTime { get; set; }
        public decimal Duration { get; set; }
        public bool StdActive { get; set; }
        public bool Editable { get; set; }
        public bool StopCounting { get; set; }
        public bool DownTime { get; set; }
        public int ShiftSetId { get; set; }

        public virtual Project Project { get; set; } = null!;
    }
}
