using System;
using System.Collections.Generic;

#nullable disable

namespace Models.db
{
    public partial class Element
    {
        public Element()
        {
            ElementCategories = new HashSet<ElementCategory>();
            LineElements = new HashSet<LineElement>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Path { get; set; }
        public int? ResX { get; set; }
        public int? ResY { get; set; }

        public virtual ICollection<ElementCategory> ElementCategories { get; set; }
        public virtual ICollection<LineElement> LineElements { get; set; }
    }
}
