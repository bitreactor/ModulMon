using System;
using System.Collections.Generic;

namespace ModulMon.Models
{
    public partial class Station
    {
        public int Id { get; set; }
        public int LineId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool VolumeProject { get; set; }
        public bool VolumeLine { get; set; }
        public short Pos { get; set; }
        public short DbValue { get; set; }

        public virtual Line Line { get; set; } = null!;
    }
}
