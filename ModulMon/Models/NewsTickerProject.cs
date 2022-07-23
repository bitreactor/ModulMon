using System;
using System.Collections.Generic;

namespace ModulMon.Models
{
    public partial class NewsTickerProject
    {
        public int Id { get; set; }
        public string NewsTickerProjectName { get; set; } = null!;
        public int PlantNum { get; set; }
        public string PageHeader { get; set; } = null!;
        public string PageContentUrl { get; set; } = null!;
        public int ScrollDelay { get; set; }
        public int ScrollAmount { get; set; }
        public int ScreenRefreshRate { get; set; }
        public int IframeRefreshRate { get; set; }
        public int ProdviewScreenId { get; set; }
        public int ChangeUserId { get; set; }
        public DateTime ChangeTime { get; set; }
    }
}
