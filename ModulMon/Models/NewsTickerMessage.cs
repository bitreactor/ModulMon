using System;
using System.Collections.Generic;

namespace ModulMon.Models
{
    public partial class NewsTickerMessage
    {
        public int Id { get; set; }
        public int NewsTickerProjectId { get; set; }
        public string MessageTextShort { get; set; } = null!;
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public bool Active { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int ChangeUserId { get; set; }
        public DateTime ChangeTime { get; set; }
    }
}
