using System;
using System.Collections.Generic;

namespace ModulMon.Models
{
    public partial class Material
    {
        public Material()
        {
            MaterialImages = new HashSet<MaterialImage>();
        }

        public int Id { get; set; }
        public string MatNum { get; set; } = null!;
        public string Descr { get; set; } = null!;
        public decimal Vt { get; set; }
        public double NumWorkers { get; set; }
        public bool Akkord { get; set; }
        public int ProjectId { get; set; }
        public int ChangeUsrId { get; set; }
        public DateTime ChangeTime { get; set; }
        public bool IsRepresentative { get; set; }
        public double NumWorkersMax { get; set; }

        public virtual Project Project { get; set; } = null!;
        public virtual ICollection<MaterialImage> MaterialImages { get; set; }
    }
}
