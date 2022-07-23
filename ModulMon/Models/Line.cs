using System;
using System.Collections.Generic;

namespace ModulMon.Models
{
    public partial class Line
    {
        public Line()
        {
            Stations = new HashSet<Station>();
            VerificationSamples = new HashSet<VerificationSample>();
        }

        public int Id { get; set; }
        public int PrjId { get; set; }
        public string Name { get; set; } = null!;
        public decimal ZielOee { get; set; }
        public decimal Lg { get; set; }
        public int FihPpmTarget { get; set; }
        public bool OnePieceFlow { get; set; }
        public int ChangeUserId { get; set; }
        public DateTime ChangeTime { get; set; }
        public short Pos { get; set; }
        public bool TwoPtWt { get; set; }
        public int DetailGrpId { get; set; }
        public bool StSerial { get; set; }
        public bool OeeReport { get; set; }
        public int OeeReportPos { get; set; }

        public virtual Project Prj { get; set; } = null!;
        public virtual ICollection<Station> Stations { get; set; }
        public virtual ICollection<VerificationSample> VerificationSamples { get; set; }
    }
}
