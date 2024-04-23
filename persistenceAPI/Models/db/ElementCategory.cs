using System;
using System.Collections.Generic;

#nullable disable

namespace Models.db
{
    public partial class ElementCategory
    {
        public int Id { get; set; }
        public int CatElementCategoryId { get; set; }
        public int ElementId { get; set; }

        public virtual CatElementCategory CatElementCategory { get; set; }
        public virtual Element Element { get; set; }
    }
}
