using System;
using System.Collections.Generic;

namespace ModulMon.Models
{
    public partial class MaterialImage
    {
        public int Id { get; set; }
        public int MatId { get; set; }
        public int ScreenNum { get; set; }
        public byte[] Image { get; set; } = null!;

        public virtual Material Mat { get; set; } = null!;
    }
}
