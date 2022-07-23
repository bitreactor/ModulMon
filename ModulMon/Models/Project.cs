using System;
using System.Collections.Generic;

namespace ModulMon.Models
{
    public partial class Project
    {
        public Project()
        {
            ErrorCodes = new HashSet<ErrorCode>();
            Lines = new HashSet<Line>();
            MaterialRepmas = new HashSet<MaterialRepma>();
            Materials = new HashSet<Material>();
            Notifications = new HashSet<Notification>();
            ProjectBreakSets = new HashSet<ProjectBreakSet>();
            ProjectMailRecipients = new HashSet<ProjectMailRecipient>();
            ProjectShiftSets = new HashSet<ProjectShiftSet>();
        }

        public int Id { get; set; }
        public int PlantId { get; set; }
        public string Name { get; set; } = null!;
        public string Kst { get; set; } = null!;
        public string DbServer { get; set; } = null!;
        public string DbName { get; set; } = null!;
        public string DbUsr { get; set; } = null!;
        public string DbPasswd { get; set; } = null!;
        public short Pos { get; set; }
        public int FihPpmTarget { get; set; }
        public int ChangeUserId { get; set; }
        public DateTime ChangeTime { get; set; }
        public int ProjectGroupId { get; set; }
        public bool Hidden { get; set; }
        public bool NotificationActive { get; set; }
        public bool AnalysePerStation { get; set; }

        public virtual Plant Plant { get; set; } = null!;
        public virtual ICollection<ErrorCode> ErrorCodes { get; set; }
        public virtual ICollection<Line> Lines { get; set; }
        public virtual ICollection<MaterialRepma> MaterialRepmas { get; set; }
        public virtual ICollection<Material> Materials { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<ProjectBreakSet> ProjectBreakSets { get; set; }
        public virtual ICollection<ProjectMailRecipient> ProjectMailRecipients { get; set; }
        public virtual ICollection<ProjectShiftSet> ProjectShiftSets { get; set; }
    }
}
