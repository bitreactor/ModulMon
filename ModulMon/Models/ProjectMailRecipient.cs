using System;
using System.Collections.Generic;

namespace ModulMon.Models
{
    public partial class ProjectMailRecipient
    {
        public int Id { get; set; }
        public int RecipientId { get; set; }
        public int ProjectId { get; set; }

        public virtual Project Project { get; set; } = null!;
        public virtual MailRecipient Recipient { get; set; } = null!;
    }
}
