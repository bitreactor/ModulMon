using System;
using System.Collections.Generic;

namespace ModulMon.Models
{
    public partial class MailRecipient
    {
        public MailRecipient()
        {
            ProjectMailRecipients = new HashSet<ProjectMailRecipient>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string MailAddress { get; set; } = null!;

        public virtual ICollection<ProjectMailRecipient> ProjectMailRecipients { get; set; }
    }
}
