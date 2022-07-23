using System;
using System.Collections.Generic;

namespace ModulMon.Models
{
    public partial class Plant
    {
        public Plant()
        {
            Projects = new HashSet<Project>();
        }

        public int Id { get; set; }
        public string PlantNum { get; set; } = null!;
        public string PlantShort { get; set; } = null!;
        public string IntName { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Town { get; set; } = null!;
        public string TimezoneId { get; set; } = null!;
        public string LocalFormatSetting { get; set; } = null!;
        public int Pos { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}
