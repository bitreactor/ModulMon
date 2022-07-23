using System;
using System.Collections.Generic;

namespace ModulMon.Models
{
    public partial class Menue
    {
        public Menue()
        {
            UsrRights = new HashSet<UsrRight>();
        }

        public int Id { get; set; }
        public int Pid { get; set; }
        public string Name { get; set; } = null!;
        public string? Link { get; set; }
        public string? Descr { get; set; }
        public int? Pos { get; set; }
        public bool? Hide { get; set; }
        public string? Code { get; set; }

        public virtual ICollection<UsrRight> UsrRights { get; set; }
    }
}
