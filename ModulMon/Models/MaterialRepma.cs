using System;
using System.Collections.Generic;

namespace ModulMon.Models
{
    public partial class MaterialRepma
    {
        public int Id { get; set; }
        public string? MatNum { get; set; }
        public string? Ind { get; set; }
        public int? Direct { get; set; }
        public float? Vgz { get; set; }
        public int? PrjId { get; set; }
        public string? Descr { get; set; }

        public virtual Project? Prj { get; set; }
    }
}
