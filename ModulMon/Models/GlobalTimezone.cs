using System;
using System.Collections.Generic;

namespace ModulMon.Models
{
    public partial class GlobalTimezone
    {
        public int Id { get; set; }
        public string TimezoneId { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string TimezoneId2 { get; set; } = null!;
        public string TimezoneId3 { get; set; } = null!;
        public string TimeDifference { get; set; } = null!;
        public bool DaylightSaving { get; set; }
    }
}
