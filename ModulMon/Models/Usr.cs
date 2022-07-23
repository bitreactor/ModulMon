using System;
using System.Collections.Generic;

namespace ModulMon.Models
{
    public partial class Usr
    {
        public Usr()
        {
            UsrLogs = new HashSet<UsrLog>();
            UsrRights = new HashSet<UsrRight>();
        }

        public int Id { get; set; }
        public string BroseId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Descr { get; set; }
        public DateTime? LastLogin { get; set; }
        public string LocalFormatSetting { get; set; } = null!;
        public int StandardPlant { get; set; }

        public virtual ICollection<UsrLog> UsrLogs { get; set; }
        public virtual ICollection<UsrRight> UsrRights { get; set; }
    }
}
