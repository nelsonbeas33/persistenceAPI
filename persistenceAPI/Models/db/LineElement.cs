using System;
using System.Collections.Generic;

#nullable disable

namespace Models.db
{
    public partial class LineElement
    {
        public int Id { get; set; }
        public int LineId { get; set; }
        public int ElementId { get; set; }
        public string Top { get; set; }
        public string Left { get; set; }

        public virtual Element Element { get; set; }
        public virtual Line Line { get; set; }
    }
}
