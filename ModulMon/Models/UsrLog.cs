using System;
using System.Collections.Generic;

namespace ModulMon.Models
{
    public partial class UsrLog
    {
        public int Id { get; set; }
        public int UsrId { get; set; }
        public DateTime Time { get; set; }
        public string Url { get; set; } = null!;
        public string Param { get; set; } = null!;
        public string IpAdr { get; set; } = null!;

        public virtual Usr Usr { get; set; } = null!;
    }
}
