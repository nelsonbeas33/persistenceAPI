using System;
using System.Collections.Generic;

#nullable disable

namespace Models.db
{
    public partial class Line
    {
        public Line()
        {
            LineCategories = new HashSet<LineCategory>();
            LineElements = new HashSet<LineElement>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }

        public virtual ICollection<LineCategory> LineCategories { get; set; }
        public virtual ICollection<LineElement> LineElements { get; set; }
    }
}
