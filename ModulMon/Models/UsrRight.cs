using System;
using System.Collections.Generic;

namespace ModulMon.Models
{
    public partial class UsrRight
    {
        public int Id { get; set; }
        public int UsrId { get; set; }
        public int MenuId { get; set; }
        public bool AllowMid { get; set; }

        public virtual Menue Menu { get; set; } = null!;
        public virtual Usr Usr { get; set; } = null!;
    }
}
